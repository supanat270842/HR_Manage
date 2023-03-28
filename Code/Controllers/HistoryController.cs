using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using HR_Management.Models;
using HR_Management.ViewModels;
using HR_Management.Services;

namespace HR_Management.Controllers;

public class HistoryController : Controller
{

    public async Task<IActionResult> Index(string headerQTDoc, ListOTViewModel dataOt)
    {
        List<ListHistoryViewModel> historyViewModel = new List<ListHistoryViewModel>();

        var dataHis = await NetworkService.getHistory(headerQTDoc);

        if (dataHis.isSuccess == true)
        {
            foreach (var item in dataHis.data)
            {
                if (!String.IsNullOrEmpty(item.docnumberImage))
                {
                    var imageData = await NetworkService.getImage(item.docnumberImage);
                    var selectImage = imageData.data[0].stfStreamId;
                    var autoIdImage = imageData.data[0].stfAutoId;

                    if (imageData.isSuccess == true)
                    {
                        historyViewModel.Add(new ListHistoryViewModel()
                        {
                            imageAutoId = autoIdImage,
                            image = selectImage,
                            headerQtdoc = dataOt.headerQTDoc,
                            headerQTDateStAffect = dataOt.headerQTDateStAffect,
                            headerQTDateEnAffect = dataOt.headerQTDateEnAffect,
                            headerQTNameYard = dataOt.headerQTNameYard,
                            headerQTLeaderName = dataOt.headerQTLeaderName,
                            headerQTSumPersons = dataOt.headerQTSumPersons,
                            itemTime = item.itemTime,
                            trTimeCheckin = item.trTimeCheckin,
                            docnumberImage = item.docnumberImage,
                            headerQTDoc = headerQTDoc,
                            note = item.note
                        });
                    }
                }
                else
                {
                    historyViewModel.Add(new ListHistoryViewModel()
                    {
                        headerQtdoc = dataOt.headerQTDoc,
                        headerQTDateStAffect = dataOt.headerQTDateStAffect,
                        headerQTDateEnAffect = dataOt.headerQTDateEnAffect,
                        headerQTNameYard = dataOt.headerQTNameYard,
                        headerQTLeaderName = dataOt.headerQTLeaderName,
                        headerQTSumPersons = dataOt.headerQTSumPersons,
                        itemTime = item.itemTime,
                        trTimeCheckin = item.trTimeCheckin,
                        image = null,
                        docnumberImage = item.docnumberImage,
                        headerQTDoc = headerQTDoc,
                        note = item.note
                    });
                }
                ViewBag.Note = item.note;
                ViewBag.DocImage = item.docnumberImage;
                ViewBag.ItemTime = item.itemTime;
            }

            ViewBag.ListHistoryViewModel = historyViewModel;
        }
        else
        {
            ViewBag.ListHistoryViewModel = historyViewModel;
        }

        if (!String.IsNullOrEmpty(dataOt._note))
        {
            dataOt._note = dataOt._note;
        }
        else
        {
            dataOt._note = "-";
        }

        var sDate = DateTime.Parse(dataOt.headerQTDateStAffect);
        var eDate = DateTime.Parse(dataOt.headerQTDateEnAffect);

        ViewBag.StartDate = sDate.ToString("yyyy-MM-dd");
        ViewBag.EndDate = eDate.ToString("yyyy-MM-dd");
        ViewBag.DocNumber = headerQTDoc;

        return View();
    }

    public async Task<IActionResult> ViewCheckIn(string headerQTDoc, string docnumberImage, int countItem, ListOTViewModel dataOt)
    {
        int i = 1;

        List<ListHistoryViewModel> historyViewModel = new List<ListHistoryViewModel>();
        List<ItemHistoryListViewModel> iViewModel = new List<ItemHistoryListViewModel>();

        var dataHis = await NetworkService.getHistory(headerQTDoc);

        if (dataHis.isSuccess == true)
        {
            if (!String.IsNullOrEmpty(docnumberImage))
            {
                var imageData = await NetworkService.getImage(docnumberImage);

                if (imageData.isSuccess == true)
                {
                    foreach (var item1 in imageData.data)
                    {
                        historyViewModel.Add(new ListHistoryViewModel()
                        {
                            imageAutoId = item1.stfAutoId,
                            image = item1.stfStreamId,
                            headerQtdoc = dataOt.headerQTDoc,
                            headerQTDateStAffect = dataOt.headerQTDateStAffect,
                            headerQTDateEnAffect = dataOt.headerQTDateEnAffect,
                            headerQTNameYard = dataOt.headerQTNameYard,
                            headerQTLeaderName = dataOt.headerQTLeaderName,
                            headerQTSumPersons = dataOt.headerQTSumPersons,
                            headerQTDoc = headerQTDoc,
                            docnumberImage = docnumberImage,
                            count = i++,
                            itemTime = countItem
                        });
                    }
                }
            }
            ViewBag.ListHistoryViewModel = historyViewModel;
        }

        ViewBag.DocNumber = headerQTDoc;
        ViewBag._Note = dataOt._note;
        ViewBag.CountItem = countItem;
        
        return View();
    }

    public async Task<IActionResult> ViewImage(ListHistoryViewModel hisModel, int _countItem, int _count)
    {
        List<ListHistoryViewModel> historyViewModel = new List<ListHistoryViewModel>();

        var dataHis = await NetworkService.getHistory(hisModel.headerQtdoc);

        var imageData = await NetworkService.getImage(hisModel.docnumberImage);
        var selectImage = imageData.data[0].stfStreamId;

        if (imageData.isSuccess == true)
        {
            var sImage = imageData.data.Where(c => c.stfAutoId == hisModel.imageAutoId);

            foreach (var item in sImage)
            {
                historyViewModel.Add(new ListHistoryViewModel()
                {
                    itemTime = hisModel.itemTime,
                    stfStreamId = item.stfStreamId,
                    note = hisModel.note,
                    image = selectImage
                });

            }
        }
       
        ViewBag.Count = _count;
        ViewBag.CountItem = _countItem;

        return View(historyViewModel);
    }

}