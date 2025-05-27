﻿using Entity.Model.Base;

namespace Entity.Model.Security
{
    public class FormModule : BaseEntity
    {
        public int FormId { get; set; }
        public Form Form { get; set; }
        public int ModuleId { get; set; }
        public Module Module { get; set; }
    }
}