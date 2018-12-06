﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Infrastructure;
using Microsoft.AspNetCore.Mvc;
using Mosaic.WebUI.Models;

namespace Mosaic.WebUI.Controllers
{
    public class GenerateController : Controller
    {
        IMakerClient client = new MakerClient();

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult GenerateMosaic(string id, bool random)
        {
            // Generate the mosaic passing the project id and whether to randomise tile selection
            var model = new GenerateMosaicModel(id);
            var response = model.Generate(client, id, random);
            if (String.IsNullOrEmpty(response.Error))
            {
                var image = new ViewImageModel();
                // copy image to root of project to display it
                image.CopyImage(response.Location);
                // Update project status and store location
                new MosaicFileModel().InsertMosaicFile(client, id, image.ImagePath);
                Response.StatusCode = (int)HttpStatusCode.OK;
                return Json(image.ImagePath);
            }
            Response.StatusCode = (int)HttpStatusCode.BadRequest;
            return Json(response.Error);
        }
    }
}