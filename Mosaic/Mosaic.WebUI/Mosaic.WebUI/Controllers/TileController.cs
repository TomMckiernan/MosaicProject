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
    public class TileController : Controller
    {
        IMakerClient client = new MakerClient();

        [HttpPost]
        public ActionResult UpdateIndexedLocation(string indexedLocation, string id)
        {
            // pass client into constructor
            var model = new IndexedLocationModel(client, id);

            var response = model.UpdateIndexedLocation(client, indexedLocation);
            if (String.IsNullOrEmpty(response.Error))
            {
                Response.StatusCode = (int)HttpStatusCode.OK;
                return Json("The indexed location request was valid");
            }
            Response.StatusCode = (int)HttpStatusCode.BadRequest;
            return Json(response.Error);
        }

        [HttpPost]
        public ActionResult ReadImageFileIndex(string indexedLocation, string id)
        {
            if (string.IsNullOrEmpty(id))
            {
                Response.StatusCode = (int)HttpStatusCode.BadRequest;
                return Json("Project id cannot be null or empty");
            }
            var model = new ImageFileIndexModel();
            model.ReadImageFileIndex(client, indexedLocation, id);

            if (String.IsNullOrEmpty(model.Error))
            {
                var tileTableModel = model.Files.Select(x => new TileTableModel(x));
                Response.StatusCode = (int)HttpStatusCode.OK;
                return Json(tileTableModel);
            }

            Response.StatusCode = (int)HttpStatusCode.BadRequest;
            return Json(model.Error);
        }

        [HttpPost]
        public ActionResult UpdateImageFileIndex(string indexedLocation)
        {
            var model = new ImageFileIndexModel();

            var response = model.UpdateImageFileIndex(client, indexedLocation);
            if (String.IsNullOrEmpty(response.Result.Error))
            {
                Response.StatusCode = (int)HttpStatusCode.OK;
                return Json("The update image file index request was valid");
            }
            Response.StatusCode = (int)HttpStatusCode.BadRequest;
            return Json(response.Result.Error);
        }

        [HttpPost]
        [RequestFormSizeLimit(valueCountLimit: 2000)]
        public ActionResult ImportTiles(string id, IEnumerable<string> fileIds)
        {
            var model = new TileFilesModel();

            var response = model.InsertSmallFiles(client, id, fileIds.ToList());
            if (String.IsNullOrEmpty(response.Error))
            {
                Response.StatusCode = (int)HttpStatusCode.OK;
                return Json("The update small file ids request was valid");
            }
            Response.StatusCode = (int)HttpStatusCode.BadRequest;
            return Json(response.Error);
        }

        public ActionResult Generate(string Id)
        {
            var model = new GenerateMosaicModel();
            model.ReadProjectData(client, Id);

            return View("Generate", model);
        }
    }
}