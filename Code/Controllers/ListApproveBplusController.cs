using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using HR_Management.Models;
using HR_Management.Services;
using Microsoft.AspNetCore.Mvc.Rendering;
using HR_Management.ViewModels;
using AspNetCoreHero.ToastNotification.Abstractions;
using HR_Management.Models.db;
using Microsoft.EntityFrameworkCore;

namespace HR_Management.Controllers;

public class ListApproveBplusController : Controller
{
    private readonly INotyfService _notyfService;
    OverTimeContext _db;
    public ListApproveBplusController(OverTimeContext db,INotyfService notyfService)
    {
        _db = db;
        _notyfService = notyfService;
    }
    public async Task<IActionResult> Index(string _factory, DateTime _startDate, DateTime _endDate)
    {

        ApproveBplusViewModel header = new ApproveBplusViewModel();
        List<ItemOtModel> itemOtModels = new List<ItemOtModel>();

        string _sDate = string.Empty;
        string _eDate = string.Empty;
        if (_endDate.ToString() == "1/1/0001 12:00:00 AM")
        {
            _sDate = DateTime.Now.ToString("yyyy-MM-dd");
            _eDate = DateTime.Now.ToString("yyyy-MM-dd");
        }
        else
        {
            _sDate = _startDate.ToString();
            _eDate = _endDate.ToString();
        }
        var sDate = DateTime.Parse(_sDate);
        var eDate = DateTime.Parse(_eDate).AddTicks(-1).AddDays(1);

        var dataPlant = await NetworkService.getPlant(); //โรงงาน
        ViewData["PlantList"] = new SelectList
        (dataPlant.data, "plantid", "plantname", _factory);

        if (_factory == null || _factory == "เลือกทั้งหมด")
        {
            var dataAlls = await (from dataAll in _db.HeaderOts
                                  where
                                  dataAll.HeaderConfirm == "Create"
                                  && dataAll.HeaderQtstatusApprove == "Approve"
                                  && dataAll.HeaderQtstatus != "Revise"
                                  && dataAll.HeaderQtstatus != "Reject"
                                  && dataAll.HeaderQtcondition == false
                                  && dataAll.HeaderQtdateStAffect >= sDate
                                  && dataAll.HeaderQtdateEnAffect <= eDate
                                  select new ApproveBplusViewModel
                                  {
                                      HeaderQtdoc = dataAll.HeaderQtdoc,
                                      HeaderQtplant = dataAll.HeaderQtplant,
                                      HeaderTypeOt = dataAll.HeaderTypeOt,
                                      HeaderQttimeStAffect = dataAll.HeaderQttimeStAffect,
                                      HeaderQttimeEnAffect = dataAll.HeaderQttimeEnAffect
                                  }
                            ).ToArrayAsync();

            foreach (var item in dataAlls)
            {
                itemOtModels.Add(new ItemOtModel()
                {
                    HeaderQtdoc = item.HeaderQtdoc,
                    HeaderQtstatusApprove = "Approve",
                    HeaderQtstatus = "Active",
                    HeaderQtplant = item.HeaderQtplant,
                    HeaderTypeOt = item.HeaderTypeOt,
                    HeaderQttimeStAffect = item.HeaderQttimeStAffect,
                    HeaderQttimeEnAffect = item.HeaderQttimeEnAffect,
                });
            }
            header.itemOts = itemOtModels;
            ViewBag.ApproveBplusViewModel = dataAlls;
        }
        else
        {
            var datas = await (from data in _db.HeaderOts
                               where data.HeaderConfirm == "Create"
                               && data.HeaderQtstatusApprove == "Approve"
                                  && data.HeaderQtstatus != "Revise"
                                  && data.HeaderQtstatus != "Reject"
                                  && data.HeaderQtcondition == false
                               && data.HeaderQtplant == _factory
                               && data.HeaderQtdateStAffect >= sDate
                               && data.HeaderQtdateEnAffect <= eDate
                               select new ApproveBplusViewModel
                               {
                                   HeaderQtdoc = data.HeaderQtdoc,
                                   HeaderQtplant = data.HeaderQtplant,
                                   HeaderTypeOt = data.HeaderTypeOt,
                                   HeaderQttimeStAffect = data.HeaderQttimeStAffect,
                                   HeaderQttimeEnAffect = data.HeaderQttimeEnAffect
                               }
                            ).ToArrayAsync();

            foreach (var item in datas)
            {
                itemOtModels.Add(new ItemOtModel()
                {
                    HeaderQtdoc = item.HeaderQtdoc,
                    HeaderQtstatusApprove = "Approve",
                    HeaderQtstatus = "Active",
                    HeaderQtplant = item.HeaderQtplant,
                    HeaderTypeOt = item.HeaderTypeOt,
                    HeaderQttimeStAffect = item.HeaderQttimeStAffect,
                    HeaderQttimeEnAffect = item.HeaderQttimeEnAffect,
                });
            }
            header.itemOts = itemOtModels;
            ViewBag.ApproveBplusViewModel = datas;
        }
        ViewBag.StartDate = sDate.ToString("yyyy-MM-dd");
        ViewBag.EndDate = eDate.ToString("yyyy-MM-dd");
        return View(header);
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Update(ApproveBplusViewModel data)
    {
        int i = 0;
        if (data.itemOts != null)
        {
            foreach (var item in data.itemOts)
            {
                if (data.itemOts[i].checkConfirm == true)
                {
                    var headers = await (from header in _db.HeaderOts
                                         where header.HeaderQtdoc == data.itemOts[i].HeaderQtdoc
                                         && header.HeaderQtstatusApprove == "Approve"
                                         && header.HeaderQtstatus == "Active"
                                         select header).FirstOrDefaultAsync();

                    headers.HeaderConfirm = "Confirm";
                    headers.HeaderQteditDate = DateTime.Now;
                    headers.HeaderQteditBy = User.Identity.Name;

                    _db.Update(headers);
                    await _db.SaveChangesAsync();
                    // ViewBag.Update = headers;
                }
                i++;
            }
            return RedirectToAction("Index", "ListApproveBplus");
        }
        return View();
    }

}