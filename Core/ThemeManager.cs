using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clock.Core
{
    public class ThemeManager
    {
        TabControl _tabControl;
        string _currentThemeKey;
        Theme _currentTheme;
        Dictionary<string, Theme> _themes = new Dictionary<string, Theme>();

        public ThemeManager(TabControl tab_control)
        {
            _tabControl = tab_control;
        }

        void SetChildsTheme(Control cntrl, Theme theme_to_apply)
        {
            foreach (Control child in cntrl.Controls)
            {
                child.BackColor = theme_to_apply.secondaryColor;
                child.ForeColor = theme_to_apply.primaryColor;
                SetChildsTheme(child, theme_to_apply);
            }
        }

        void SwitchThemeTo(Theme theme)
        {
            foreach (TabPage tab in _tabControl.TabPages)
            {
                tab.BackColor = theme.primaryColor;
                SetChildsTheme(tab, theme);
            }
        }

        public bool Add(Color primary_color, Color secondary_color, string key)
        {
            if (key == "")
                return false;
            _themes.Add(key, new Theme(primary_color, secondary_color));
            return true;
        }

        public bool SwitchTo(string theme_key)
        {
            if (!_themes.ContainsKey(theme_key))
                return false;
            _currentTheme = _themes[theme_key];
            _currentThemeKey = theme_key;
            SwitchThemeTo(_currentTheme);
            return true;
        }

        public bool IsExistWith(string key)
        {
            return _themes.ContainsKey(key);
        }

        public string CurrentThemeKey
        {
            get
            {
                return _currentThemeKey;
            }
        }
    }
}
