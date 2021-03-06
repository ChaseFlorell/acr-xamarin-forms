﻿using System;
using System.IO;


namespace Acr.XamForms.Mobile {

    public interface IImageService {

        IImage Load(Stream stream);
        IImage Load(byte[] bytes);
        IImage Load(string path);
    }
}
