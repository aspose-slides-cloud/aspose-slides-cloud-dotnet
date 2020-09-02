using Aspose.Slides.Cloud.Live.Demos.UI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Aspose.Slides.Cloud.Live.Demos.UI.Controllers
{
	public class HomeController : BaseController
	{
	
		public override string Product => (string)RouteData.Values["productname"];
		

		public ActionResult Default()
		{
			ViewBag.PageTitle = "Build PowerPoint Creator & Viewer for Cloud (C# REST SDK)";
			ViewBag.MetaDescription = "Aspose.Slides Cloud SDK for .NET helps you create PowerPoint & OpenOffice presentations using C#, ASP.NET etc. Cloud API to view & convert PPT, PPTX, ODP & OTP.";
			var model = new LandingPageModel(this);

			return View(model);
		}
	}
}
