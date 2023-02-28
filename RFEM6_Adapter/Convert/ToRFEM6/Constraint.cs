﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using BH.oM.Adapter;
using BH.oM.Structure.Elements;
using BH.oM.Structure.Constraints;
using BH.Engine.Adapter;
using BH.oM.Adapters.RFEM6;

using rfModel = Dlubal.WS.Rfem6.Model;

namespace BH.Adapter.RFEM6
{
    public partial class Convert
    {

        public static rfModel.nodal_support ToRFEM6(this Constraint6DOF bhSupport)//, int constraintSupportNo)
        {
            rfModel.nodal_support rfNodelSupport = new rfModel.nodal_support()
            {
                no = bhSupport.GetRFEM6ID(),
                name = bhSupport.Name,
               // nodes = new int[] { constraintSupportNo },
                spring = new rfModel.vector_3d() { x = stiffnessTranslationBHToRF("" + bhSupport.TranslationX), y = stiffnessTranslationBHToRF("" + bhSupport.TranslationY), z = stiffnessTranslationBHToRF("" + bhSupport.TranslationZ) },
                rotational_restraint = new rfModel.vector_3d() { x = stiffnessTranslationBHToRF("" + bhSupport.RotationX), y = stiffnessTranslationBHToRF("" + bhSupport.RotationY), z = stiffnessTranslationBHToRF("" + bhSupport.RotationZ) },
            };
            return rfNodelSupport;
        }


        public static double stiffnessTranslationBHToRF(string stiffness)
        {

            double result = stiffness == "Free" ? 0.0 : double.PositiveInfinity;

            return result;
        }
    }
}
