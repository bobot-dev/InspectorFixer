using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace InspectorFixer
{
    class InspectorFixer : MonoBehaviour
    {
        void OnGUI()
        {
            GUI.skin.font = null;

            GUI.skin.textField.normal.textColor = new Color32(184, 184, 184, 255);
            GUI.skin.textField.active.textColor = new Color32(255, 255, 255, 255);
            GUI.skin.textField.hover.textColor = new Color32(227, 227, 227, 255);
            GUI.skin.textField.focused.textColor = new Color32(255, 255, 255, 255);

            GUI.skin.textField.normal.background = SetupBackground(new Color32(46, 46, 46, 255));
            GUI.skin.textField.active.background = SetupBackground(new Color32(0, 0, 0, 255));
            GUI.skin.textField.hover.background = SetupBackground(new Color32(61, 61, 61, 255));
            GUI.skin.textField.focused.background = SetupBackground(new Color32(23, 23, 23, 255));

            GUI.backgroundColor = new Color32(20, 20, 20, 255);

            GUI.skin.label.alignment = TextAnchor.MiddleCenter;
            GUI.skin.textField.alignment = TextAnchor.MiddleLeft;
            GUI.skin.verticalScrollbar.fixedWidth = 16f;
            GUI.skin.verticalScrollbarThumb.fixedWidth = 16f;
        }

        Texture2D SetupBackground(Color color)
        {
            var bg = new Texture2D(1, 1);
            bg.SetPixel(0, 0, color);
            bg.Apply();
            return bg;
        }
    }
}
