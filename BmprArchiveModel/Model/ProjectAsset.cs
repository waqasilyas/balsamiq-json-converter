﻿using System;
using Newtonsoft.Json;
using BmprArchiveModel.Model.Properties;

namespace BmprArchiveModel.Model
{
    public class ProjectAsset
    {
        public String Id { get; set; }
        public String BranchId { get; set; }
        public ResourceAttributes Attributes { get; set; }

        public String Data { get; set; }
        public String DataHash { get; set; }
    }
}
