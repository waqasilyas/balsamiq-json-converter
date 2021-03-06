﻿using System.Collections.Generic;

namespace BmprArchiveModel.Model
{
    public class MockupProject
    {
        #region Properties

        public ProjectInfo Info { get; set; }
        public List<Mockup> Mockups { get; set; } = new List<Mockup>();
        public List<SymbolLibrary> SymbolLibraries { get; set; } = new List<SymbolLibrary>();
        public List<ProjectAsset> Assets { get; set;  } = new List<ProjectAsset>();
        public List<BranchInfo> Branches { get; set; } = new List<BranchInfo>();
        public List<ResourceThumbnail> Thumbnails { get; set; } = new List<ResourceThumbnail>();
        #endregion
    }
}
