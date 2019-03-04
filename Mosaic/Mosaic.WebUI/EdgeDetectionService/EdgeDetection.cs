﻿using System;
using System.Collections.Generic;
using System.Text;

namespace EdgeDetectionService
{
    public class EdgeDetection
    {
        public EdgeDetectionResponse PreviewEdges(EdgeDetectionRequest request)
        {
            var sobelGenerator = new SobelGenerator();
            var edges = sobelGenerator.Generate(request.Id);
            var location = string.Format("C:\\Users\\Tom_m\\OneDrive\\Pictures\\EdgeImageTests\\{0}.jpg", request.Id);
            edges.Image.Save(location);
            edges.Image.Dispose();
            var response = new EdgeDetectionResponse() { Location = location };
            response.Edges.AddRange(edges.Edges);
            return response;
        }
    }
}