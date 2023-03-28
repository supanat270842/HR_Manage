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

public class ReportApproveOTController : Controller
{
    private readonly INotyfService _notyfService;
    OverTimeContext _db;
    public ReportApproveOTController(OverTimeContext db,INotyfService notyfService)
    {
        _db = db;
        _notyfService = notyfService;
    }
    public async Task<IActionResult> Index(string _factory, DateTime _startDate, DateTime _endDate)
    {

        ReportApproveOTViewModel header = new ReportApproveOTViewModel();
        List<ItemApproveOtModel> itemOtModels = new List<ItemApproveOtModel>();

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
                                join r in _db.RemarkCdtOttypes on dataAll.HeaderQtdoc equals r.RmheaderQtdoc
                                join o in _db.Ottypes on dataAll.OttAutoId equals o.OttAutoId
                                  where
                                  dataAll.HeaderConfirm == "Create"
                                  && dataAll.HeaderQtstatusApprove == "Approve"
                                  && dataAll.HeaderQtstatus != "Revise"
                                  && dataAll.HeaderQtstatus != "Reject"
                                  && dataAll.HeaderQtcondition == false
                                  && dataAll.HeaderQtdateStAffect >= sDate
                                  && dataAll.HeaderQtdateEnAffect <= eDate
                                  select new ReportApproveOTViewModel
                                  {
                                      HeaderQtdoc = dataAll.HeaderQtdoc,
                                      OttName = o.OttName,
                                      HeaderTypeOt = dataAll.HeaderTypeOt,
                                      HeaderQttimeStAffect = dataAll.HeaderQttimeStAffect,
                                      HeaderQttimeEnAffect = dataAll.HeaderQttimeEnAffect,
                                      HeaderQtSum = dataAll.HeaderQtsumPersons,
                                      RMRemark = r.Rmremark

                                  }
                            ).ToArrayAsync();

            foreach (var item in dataAlls)
            {
                itemOtModels.Add(new ItemApproveOtModel()
                {
                    HeaderQtdoc = item.HeaderQtdoc,
                    HeaderQtstatusApprove = "Approve",
                    HeaderQtstatus = "Active",
                    OttName = item.OttName,
                    HeaderQtplant = item.HeaderQtplant,
                    HeaderTypeOt = item.HeaderTypeOt,
                    HeaderQttimeStAffect = item.HeaderQttimeStAffect,
                    HeaderQttimeEnAffect = item.HeaderQttimeEnAffect,
                    HeaderQtSum = item.HeaderQtSum,
                    RMRemark = item.RMRemark
                });
            }
            header.itemOts = itemOtModels;
            ViewBag.ApproveBplusViewModel = dataAlls;
            
        }
        else
        {
            var datas = await (from data in _db.HeaderOts
                                join r in _db.RemarkCdtOttypes on data.HeaderQtdoc equals r.RmheaderQtdoc
                                join o in _db.Ottypes on data.OttAutoId equals o.OttAutoId
                               where data.HeaderConfirm == "Create"
                               && data.HeaderQtstatusApprove == "Approve"
                                  && data.HeaderQtstatus != "Revise"
                                  && data.HeaderQtstatus != "Reject"
                                  && data.HeaderQtcondition == false
                               && data.HeaderQtplant == _factory
                               && data.HeaderQtdateStAffect >= sDate
                               && data.HeaderQtdateEnAffect <= eDate
                               select new ReportApproveOTViewModel
                                  {
                                      HeaderQtdoc = data.HeaderQtdoc,
                                      OttName = o.OttName,
                                      HeaderTypeOt = data.HeaderTypeOt,
                                      HeaderQttimeStAffect = data.HeaderQttimeStAffect,
                                      HeaderQttimeEnAffect = data.HeaderQttimeEnAffect,
                                      HeaderQtSum = data.HeaderQtsumPersons,
                                      RMRemark = r.Rmremark
                                  }
                            ).ToArrayAsync();

            foreach (var item in datas)
            {
                itemOtModels.Add(new ItemApproveOtModel()
                {
                    HeaderQtdoc = item.HeaderQtdoc,
                    HeaderQtstatusApprove = "Approve",
                    HeaderQtstatus = "Active",
                    HeaderQtplant = item.HeaderQtplant,
                    OttName = item.OttName,
                    HeaderTypeOt = item.HeaderTypeOt,
                    HeaderQttimeStAffect = item.HeaderQttimeStAffect,
                    HeaderQttimeEnAffect = item.HeaderQttimeEnAffect,
                    HeaderQtSum = item.HeaderQtSum,
                    RMRemark = item.RMRemark
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
    public async Task<IActionResult> Update(ReportApproveOTViewModel data)
    {
        int i = 0;
        int checkUpdate = 0;
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
                    checkUpdate++;
                }
                i++;
            }

            if(checkUpdate == 0)
            {
                _notyfService.Error("กรุณาเลือกรายการเพื่อทำการ Approve");
            }
            else
            {
                _notyfService.Success("ทำการบันทึกรายการสำเร็จ");
            }
            
            return RedirectToAction("Index", "ReportApproveOT");
        }
        return View();
    }

}