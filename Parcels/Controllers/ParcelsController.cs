using Microsoft.AspNetCore.Mvc;
using Parcels.Models;
using System.Collections.Generic;

namespace Parcels.Controllers
{
  public class ParcelsController : Controller
  {
    [HttpPost("/parcels")]
    public ActionResult Create(int weight, int height, int width, int length, string desc)
    {
      Parcel myParcel = new Parcel(weight, height, width, length, desc);
      return RedirectToAction("Index");
    }
    [HttpGet("/parcels")]
    public ActionResult Index()
    {
      List<Parcel> allParcels = Parcel.GetAll();
      return View(allParcels);
    }
    [HttpGet("/parcels/new")]
    public ActionResult CreateForm()
    {
      return View();
    }
  }
}