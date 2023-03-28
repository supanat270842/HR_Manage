using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using HR_Management.Models;
using HR_Management.Services;
using Microsoft.AspNetCore.Mvc.Rendering;
using HR_Management.ViewModels;
using AspNetCoreHero.ToastNotification.Abstractions;

namespace HR_Management.Controllers;

public class EmployeeController : Controller
{

    public async Task<IActionResult> Index(string docNumber)
    {
        var dataEmployee = await NetworkService.getOtByDoc(docNumber);
        var dataEm = dataEmployee.data.itemOts.Where(c => c.itemQTDoc == docNumber);
        
        ViewBag.DocNumber = docNumber;

        return View(dataEm);
    }

}