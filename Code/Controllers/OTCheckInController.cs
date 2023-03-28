using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using HR_Management.Models;
using HR_Management.Services;
using Microsoft.AspNetCore.Mvc.Rendering;
using HR_Management.ViewModels;
using AspNetCoreHero.ToastNotification.Abstractions;

namespace HR_Management.Controllers;

public class OTCheckInController : Controller
{

    private readonly INotyfService _notyfService;

    public OTCheckInController(INotyfService notyfService)
    {
        _notyfService = notyfService;
    }

    public async Task<IActionResult> Index(string _factory, string _department, DateTime _startDate, DateTime _endDate, string docNumber)
    {
        List<ListOTViewModel> listOTViewModels = new List<ListOTViewModel>();

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


        var dataFD = await NetworkService.getFac_Dep(); //แผนก
        ViewData["FacAndDepList"] = new SelectList
        (dataFD.data.Where(c => c.factoryName == _factory), "factoryDepartmentsId", "factoryDepartments", _department);

        if (_factory == null || (_factory == "เลือกทั้งหมด" && _department == "เลือกทั้งหมด"))
        {
            var resultListOT = await NetworkService.getListOTByDate(sDate.ToString("yyyy-MM-dd"), eDate.ToString("yyyy-MM-dd"));

            foreach (var item in resultListOT.data)
            {
                var dataEmployee = await NetworkService.getOtByDoc(item.headerQTDoc);

                var dataOTByDoc = await NetworkService.getOtByDoc(item.headerQTDoc);

                listOTViewModels.Add(new ListOTViewModel()
                {
                    headerQTLeaderID = item.headerQTLeaderID,
                    headerQTDoc = item.headerQTDoc,
                    headerQTDateStAffect = item.headerQTDateStAffect.Substring(0, 10),
                    headerQTTimeStAffect = item.headerQTTimeStAffect,
                    headerQTDateEnAffect = item.headerQTDateEnAffect.Substring(0, 10),
                    headerQTTimeEnAffect = item.headerQTTimeEnAffect,
                    headerQTNameYard = item.headerQTNameYard,
                    headerQTLeaderName = item.headerQTLeaderName,
                    headerQTSumPersons = item.headerQTSumPersons,
                    _note = dataOTByDoc.data.headerQTDetailOT

                });               
            }
            ViewBag.ListOTViewModel = listOTViewModels;
        }
        else if (_factory == _factory && _department == "เลือกทั้งหมด")
        {
            var resultListOT = await NetworkService.getListOTByDate(sDate.ToString("yyyy-MM-dd"), eDate.ToString("yyyy-MM-dd"));

            var whereListOT = resultListOT.data.Where(c => c.headerQTPlant == _factory);

            foreach (var item in whereListOT)
            {
                var dataOTByDoc = await NetworkService.getOtByDoc(item.headerQTDoc);

                listOTViewModels.Add(new ListOTViewModel()
                {
                    headerQTLeaderID = item.headerQTLeaderID,
                    headerQTDoc = item.headerQTDoc,
                    headerQTDateStAffect = item.headerQTDateStAffect.Substring(0, 10),
                    headerQTTimeStAffect = item.headerQTTimeStAffect,
                    headerQTDateEnAffect = item.headerQTDateEnAffect.Substring(0, 10),
                    headerQTTimeEnAffect = item.headerQTTimeEnAffect,
                    headerQTNameYard = item.headerQTNameYard,
                    headerQTLeaderName = item.headerQTLeaderName,
                    headerQTSumPersons = item.headerQTSumPersons,
                    _note = dataOTByDoc.data.headerQTDetailOT

                });
            }
            ViewBag.ListOTViewModel = listOTViewModels;
        }
        else if (_factory == _factory && _department == _department)
        {
            var resultListOT = await NetworkService.getListOT(_factory, _department, sDate.ToString("yyyy-MM-dd"), eDate.ToString("yyyy-MM-dd"));

            foreach (var item in resultListOT.data)
            {
                var dataOTByDoc = await NetworkService.getOtByDoc(item.headerQTDoc);

                listOTViewModels.Add(new ListOTViewModel()
                {
                    headerQTLeaderID = item.headerQTLeaderID,
                    headerQTDoc = item.headerQTDoc,
                    headerQTDateStAffect = item.headerQTDateStAffect.Substring(0, 10),
                    headerQTTimeStAffect = item.headerQTTimeStAffect,
                    headerQTDateEnAffect = item.headerQTDateEnAffect.Substring(0, 10),
                    headerQTTimeEnAffect = item.headerQTTimeEnAffect,
                    headerQTNameYard = item.headerQTNameYard,
                    headerQTLeaderName = item.headerQTLeaderName,
                    headerQTSumPersons = item.headerQTSumPersons,
                    _note = dataOTByDoc.data.headerQTDetailOT

                });
            }
            ViewBag.ListOTViewModel = listOTViewModels;

        }
        else
        {
            ViewBag.ListOTViewModel = listOTViewModels;
        }


        ViewBag.StartDate = sDate.ToString("yyyy-MM-dd");
        ViewBag.EndDate = eDate.ToString("yyyy-MM-dd");

        return View();
    }

}