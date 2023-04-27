﻿/*
 * This file is part of the Buildings and Habitats object Model (BHoM)
 * Copyright (c) 2015 - 2023, the respective contributors. All rights reserved.
 *
 * Each contributor holds copyright over their respective contributions.
 * The project versioning (Git) records all such contribution source information.
 *                                           
 *                                                                              
 * The BHoM is free software: you can redistribute it and/or modify         
 * it under the terms of the GNU Lesser General Public License as published by  
 * the Free Software Foundation, either version 3.0 of the License, or          
 * (at your option) any later version.                                          
 *                                                                              
 * The BHoM is distributed in the hope that it will be useful,              
 * but WITHOUT ANY WARRANTY; without even the implied warranty of               
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the                 
 * GNU Lesser General Public License for more details.                          
 *                                                                            
 * You should have received a copy of the GNU Lesser General Public License     
 * along with this code. If not, see <https://www.gnu.org/licenses/lgpl-3.0.html>.      
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BH.oM.Base;
using System.ComponentModel;
using BH.oM.Structure.Elements;

namespace BH.oM.Adapters.RFEM6
{
    public class RFEMLine : BHoMObject, IFragment
    {
        //[Description("Defines the start position of the element. Note that Nodes can contain Supports which should not be confused with Releases.")]
        //public virtual Node StartNode { get; set; }
        //[Description("Defines the end position of the element. Note that Nodes can contain Supports which should not be confused with Releases.")]
        //public virtual Node EndNode { get; set; }

        public virtual List<Node> Nodes { get; set; } = new List<Node>();

        public virtual RFEMLineType LineType { get; set; } = RFEMLineType.Polyline;

        public virtual double Radius { get; set; } = 0;

        public virtual double Angle { get; set; } = 0;

        public virtual double[] X_Vector { get; set; } = new double[3];
        public virtual double[] Y_Vector { get; set; } = new double[3];

        public virtual double[] Normal { get; set; } = new double[3];
    }
}