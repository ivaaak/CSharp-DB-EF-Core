﻿using System;
using System.Collections.Generic;
using System.Text;

namespace VaporStore.DataProcessor.Dto.Export
{
    public class GameExDto
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Developer { get; set; }
        public string Tags { get; set; }
        public int Players { get; set; }
    }
}
