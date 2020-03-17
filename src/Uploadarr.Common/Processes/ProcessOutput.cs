﻿using System.Collections.Generic;
using System.Linq;

namespace Uploadarr.Common
{
    public class ProcessOutput
    {
        public int ExitCode { get; set; }
        public List<ProcessOutputLine> Lines { get; set; }

        public ProcessOutput()
        {
            Lines = new List<ProcessOutputLine>();
        }

        public List<ProcessOutputLine> Standard
        {
            get
            {
                return Lines.Where(c => c.Level == ProcessOutputLevel.Standard).ToList();
            }
        }

        public List<ProcessOutputLine> Error
        {
            get
            {
                return Lines.Where(c => c.Level == ProcessOutputLevel.Error).ToList();
            }
        }
    }
}
