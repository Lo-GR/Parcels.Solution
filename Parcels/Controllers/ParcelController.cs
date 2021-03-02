using Microsoft.AspNetCore.Mvc;
using Parcels.Models;
using System.Collections.Generic;

namespace Parcels.Controllers
{
  public class ParcelController : Controller
  {
    [HttpPost("/parcels")]
    public ActionResult CreateForm(int weight, int height, int width, int length, string desc)
    {
      Parcel myParcel = new Parcel(weight, height, width, length, desc);
      return RedirectToAction("Index");
    }
  }
}