﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CharSystem.Models
{
    public class CharTransformerLowerCase: ICharTransformer
    {
        public String Transform(String text)
        {
            return text.ToLower();
        }
    }
}