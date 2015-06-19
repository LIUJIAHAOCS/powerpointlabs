﻿using System;
using System.Collections.Generic;
using System.IO;
using Microsoft.Office.Interop.PowerPoint;

namespace FunctionalTestInterface
{
    public interface IPowerPointOperations
    {
        void EnterFunctionalTest();
        void ExitFunctionalTest();
        bool IsInFunctionalTest();
        void ClosePresentation();
        void ActivatePresentation();
        int PointsToScreenPixelsX(float x);
        int PointsToScreenPixelsY(float y);
        Boolean IsOffice2010();
        Boolean IsOffice2013();

        Slide GetCurrentSlide();
        Slide SelectSlide(int index);
        Slide SelectSlide(string slideName);
        Slide[] GetAllSlides();

        Selection GetCurrentSelection();
        ShapeRange SelectShapes(string shapeName);
        ShapeRange SelectShapes(IEnumerable<string> shapeNames);
        ShapeRange SelectShapesByPrefix(string prefix);
        FileInfo ExportSelectedShapes();
        string SelectAllTextInShape(string shapeName);
        string SelectTextInShape(string shapeName, int startIndex, int endIndex);
    }
}