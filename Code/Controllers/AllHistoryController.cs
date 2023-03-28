using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using HR_Management.Models;
using HR_Management.ViewModels;
using HR_Management.Services;
using HR_Management.Models.db;
using Microsoft.EntityFrameworkCore;

namespace HR_Management.Controllers;

public class AllHistoryController : Controller
{
    OverTimeContext _db;
    public AllHistoryController(OverTimeContext db)
    {
        _db = db;
    }

    public async Task<IActionResult> Index(string docNumber)
    {

        if (docNumber != null)
        {
            var docs = await (from doc in _db.TransectionsCheckins
                              where doc.TrStatus == "Active"
                              && doc.HeaderQtdoc == docNumber
                              select new ListHistoryViewModel
                              {
                                  trSlot = (int)doc.TrSlot,
                                  trAutoId = doc.TrAutoId,
                                  headerQtdoc = doc.HeaderQtdoc,
                                  trTimeCheckin = doc.TrTimeCheckin.ToString(),
                                  trCreateBy = doc.TrCreateBy,
                                  reMark = doc.TrRemark,
                                  trActivity = (int)doc.TrActivity
                              }).ToArrayAsync();

            ViewBag.ListHistoryViewModel = docs;
        }
        else
        {
            return NotFound();
        }
        ViewBag.DocNumber = docNumber;

        return View();
    }

}