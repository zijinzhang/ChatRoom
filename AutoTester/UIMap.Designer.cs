﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by coded UI test builder.
//      Version: 14.0.0.0
//
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------

namespace AutoTester
{
    using System;
    using System.CodeDom.Compiler;
    using System.Collections.Generic;
    using System.Drawing;
    using System.Text.RegularExpressions;
    using System.Windows.Input;
    using Microsoft.VisualStudio.TestTools.UITest.Extension;
    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;
    using Microsoft.VisualStudio.TestTools.UITesting.WpfControls;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Keyboard = Microsoft.VisualStudio.TestTools.UITesting.Keyboard;
    using Mouse = Microsoft.VisualStudio.TestTools.UITesting.Mouse;
    using MouseButtons = System.Windows.Forms.MouseButtons;
    
    
    [GeneratedCode("Coded UITest Builder", "14.0.23107.0")]
    public partial class UIMap
    {
        
        /// <summary>
        /// WebChatTest1 - Use 'WebChatTest1Params' to pass parameters into this method.
        /// </summary>
        public void WebChatTest1()
        {
            #region Variable Declarations
            WinEdit uINameEdit = this.UIDebugWindow.UIItemWindow.UIChatRoomMainexeListItem.UINameEdit;
            WpfEdit uITextBoxEdit = this.UIMainWindowWindow.UITextBoxEdit;
            WinList uIItemsViewList = this.UIDebugWindow.UIShellViewWindow.UIShellViewClient.UIItemsViewList;
            WpfButton uIGOButton = this.UIMainWindowWindow.UIGOButton;
            WinButton uIOKButton = this.UIOKWindow.UIOKButton;
            WpfEdit uIMessageBoxEdit = this.UIChatRoomWindow.UIMessageBoxEdit;
            WpfButton uISendButton = this.UIChatRoomWindow.UISendButton;
            #endregion

            // Double-Click 'Name' text box
            Mouse.DoubleClick(uINameEdit, new Point(118, 8));

            // Click 'textBox' text box
            Mouse.Click(uITextBoxEdit, new Point(131, 22));

            // Type 'Louis' in 'Items View' list box
            Keyboard.SendKeys(uIItemsViewList, this.WebChatTest1Params.UIItemsViewListSendKeys, ModifierKeys.None);

            // Click 'Go!' button
            Mouse.Click(uIGOButton, new Point(41, 21));

            // Click 'OK' button
            Mouse.Click(uIOKButton, new Point(47, 9));

            // Type 'louis' in 'textBox' text box
            uITextBoxEdit.Text = this.WebChatTest1Params.UITextBoxEditText;

            // Click 'Go!' button
            Mouse.Click(uIGOButton, new Point(23, 12));

            // Click 'OK' button
            Mouse.Click(uIOKButton, new Point(36, 1));

            // Type 'louistest' in 'textBox' text box
            uITextBoxEdit.Text = this.WebChatTest1Params.UITextBoxEditText1;

            // Click 'Go!' button
            Mouse.Click(uIGOButton, new Point(55, 10));

            // Type 'HEHEHE' in 'messageBox' text box
            uIMessageBoxEdit.Text = this.WebChatTest1Params.UIMessageBoxEditText;

            // Click 'Send' button
            Mouse.Click(uISendButton, new Point(26, 16));
        }
        
        #region Properties
        public virtual WebChatTest1Params WebChatTest1Params
        {
            get
            {
                if ((this.mWebChatTest1Params == null))
                {
                    this.mWebChatTest1Params = new WebChatTest1Params();
                }
                return this.mWebChatTest1Params;
            }
        }
        
        public UIDebugWindow UIDebugWindow
        {
            get
            {
                if ((this.mUIDebugWindow == null))
                {
                    this.mUIDebugWindow = new UIDebugWindow();
                }
                return this.mUIDebugWindow;
            }
        }
        
        public UIMainWindowWindow UIMainWindowWindow
        {
            get
            {
                if ((this.mUIMainWindowWindow == null))
                {
                    this.mUIMainWindowWindow = new UIMainWindowWindow();
                }
                return this.mUIMainWindowWindow;
            }
        }
        
        public UIOKWindow UIOKWindow
        {
            get
            {
                if ((this.mUIOKWindow == null))
                {
                    this.mUIOKWindow = new UIOKWindow();
                }
                return this.mUIOKWindow;
            }
        }
        
        public UIChatRoomWindow UIChatRoomWindow
        {
            get
            {
                if ((this.mUIChatRoomWindow == null))
                {
                    this.mUIChatRoomWindow = new UIChatRoomWindow();
                }
                return this.mUIChatRoomWindow;
            }
        }
        #endregion
        
        #region Fields
        private WebChatTest1Params mWebChatTest1Params;
        
        private UIDebugWindow mUIDebugWindow;
        
        private UIMainWindowWindow mUIMainWindowWindow;
        
        private UIOKWindow mUIOKWindow;
        
        private UIChatRoomWindow mUIChatRoomWindow;
        #endregion
    }
    
    /// <summary>
    /// Parameters to be passed into 'WebChatTest1'
    /// </summary>
    [GeneratedCode("Coded UITest Builder", "14.0.23107.0")]
    public class WebChatTest1Params
    {
        
        #region Fields
        /// <summary>
        /// Type 'Louis' in 'Items View' list box
        /// </summary>
        public string UIItemsViewListSendKeys = "Louis";
        
        /// <summary>
        /// Type 'louis' in 'textBox' text box
        /// </summary>
        public string UITextBoxEditText = "louis";
        
        /// <summary>
        /// Type 'louistest' in 'textBox' text box
        /// </summary>
        public string UITextBoxEditText1 = "louistest";
        
        /// <summary>
        /// Type 'HEHEHE' in 'messageBox' text box
        /// </summary>
        public string UIMessageBoxEditText = "HEHEHE";
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "14.0.23107.0")]
    public class UIDebugWindow : WinWindow
    {
        
        public UIDebugWindow()
        {
            #region Search Criteria
            this.SearchProperties[WinWindow.PropertyNames.Name] = "Debug";
            this.SearchProperties[WinWindow.PropertyNames.ClassName] = "CabinetWClass";
            this.WindowTitles.Add("Debug");
            #endregion
        }
        
        #region Properties
        public UIItemWindow UIItemWindow
        {
            get
            {
                if ((this.mUIItemWindow == null))
                {
                    this.mUIItemWindow = new UIItemWindow(this);
                }
                return this.mUIItemWindow;
            }
        }
        
        public UIShellViewWindow UIShellViewWindow
        {
            get
            {
                if ((this.mUIShellViewWindow == null))
                {
                    this.mUIShellViewWindow = new UIShellViewWindow(this);
                }
                return this.mUIShellViewWindow;
            }
        }
        #endregion
        
        #region Fields
        private UIItemWindow mUIItemWindow;
        
        private UIShellViewWindow mUIShellViewWindow;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "14.0.23107.0")]
    public class UIItemWindow : WinWindow
    {
        
        public UIItemWindow(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WinWindow.PropertyNames.AccessibleName] = "Items View";
            this.SearchProperties[WinWindow.PropertyNames.ClassName] = "DirectUIHWND";
            this.WindowTitles.Add("Debug");
            #endregion
        }
        
        #region Properties
        public UIChatRoomMainexeListItem UIChatRoomMainexeListItem
        {
            get
            {
                if ((this.mUIChatRoomMainexeListItem == null))
                {
                    this.mUIChatRoomMainexeListItem = new UIChatRoomMainexeListItem(this);
                }
                return this.mUIChatRoomMainexeListItem;
            }
        }
        #endregion
        
        #region Fields
        private UIChatRoomMainexeListItem mUIChatRoomMainexeListItem;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "14.0.23107.0")]
    public class UIChatRoomMainexeListItem : WinListItem
    {
        
        public UIChatRoomMainexeListItem(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WinListItem.PropertyNames.Name] = "ChatRoomMain.exe";
            this.WindowTitles.Add("Debug");
            #endregion
        }
        
        #region Properties
        public WinEdit UINameEdit
        {
            get
            {
                if ((this.mUINameEdit == null))
                {
                    this.mUINameEdit = new WinEdit(this);
                    #region Search Criteria
                    this.mUINameEdit.SearchProperties[WinEdit.PropertyNames.Name] = "Name";
                    this.mUINameEdit.WindowTitles.Add("Debug");
                    #endregion
                }
                return this.mUINameEdit;
            }
        }
        #endregion
        
        #region Fields
        private WinEdit mUINameEdit;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "14.0.23107.0")]
    public class UIShellViewWindow : WinWindow
    {
        
        public UIShellViewWindow(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WinWindow.PropertyNames.Name] = "ShellView";
            this.SearchProperties[WinWindow.PropertyNames.ClassName] = "SHELLDLL_DefView";
            this.WindowTitles.Add("Debug");
            #endregion
        }
        
        #region Properties
        public UIShellViewClient UIShellViewClient
        {
            get
            {
                if ((this.mUIShellViewClient == null))
                {
                    this.mUIShellViewClient = new UIShellViewClient(this);
                }
                return this.mUIShellViewClient;
            }
        }
        #endregion
        
        #region Fields
        private UIShellViewClient mUIShellViewClient;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "14.0.23107.0")]
    public class UIShellViewClient : WinClient
    {
        
        public UIShellViewClient(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WinControl.PropertyNames.Name] = "Shell Folder View";
            this.WindowTitles.Add("Debug");
            #endregion
        }
        
        #region Properties
        public WinList UIItemsViewList
        {
            get
            {
                if ((this.mUIItemsViewList == null))
                {
                    this.mUIItemsViewList = new WinList(this);
                    #region Search Criteria
                    this.mUIItemsViewList.SearchProperties[WinList.PropertyNames.Name] = "Items View";
                    this.mUIItemsViewList.WindowTitles.Add("Debug");
                    #endregion
                }
                return this.mUIItemsViewList;
            }
        }
        #endregion
        
        #region Fields
        private WinList mUIItemsViewList;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "14.0.23107.0")]
    public class UIMainWindowWindow : WpfWindow
    {
        
        public UIMainWindowWindow()
        {
            #region Search Criteria
            this.SearchProperties[WpfWindow.PropertyNames.Name] = "MainWindow";
            this.SearchProperties.Add(new PropertyExpression(WpfWindow.PropertyNames.ClassName, "HwndWrapper", PropertyExpressionOperator.Contains));
            this.WindowTitles.Add("MainWindow");
            #endregion
        }
        
        #region Properties
        public WpfEdit UITextBoxEdit
        {
            get
            {
                if ((this.mUITextBoxEdit == null))
                {
                    this.mUITextBoxEdit = new WpfEdit(this);
                    #region Search Criteria
                    this.mUITextBoxEdit.SearchProperties[WpfEdit.PropertyNames.AutomationId] = "textBox";
                    this.mUITextBoxEdit.WindowTitles.Add("MainWindow");
                    #endregion
                }
                return this.mUITextBoxEdit;
            }
        }
        
        public WpfButton UIGOButton
        {
            get
            {
                if ((this.mUIGOButton == null))
                {
                    this.mUIGOButton = new WpfButton(this);
                    #region Search Criteria
                    this.mUIGOButton.SearchProperties[WpfButton.PropertyNames.AutomationId] = "button";
                    this.mUIGOButton.WindowTitles.Add("MainWindow");
                    #endregion
                }
                return this.mUIGOButton;
            }
        }
        #endregion
        
        #region Fields
        private WpfEdit mUITextBoxEdit;
        
        private WpfButton mUIGOButton;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "14.0.23107.0")]
    public class UIOKWindow : WinWindow
    {
        
        public UIOKWindow()
        {
            #region Search Criteria
            this.SearchProperties[WinWindow.PropertyNames.Name] = "OK";
            this.SearchProperties[WinWindow.PropertyNames.ClassName] = "Button";
            this.WindowTitles.Add("OK");
            #endregion
        }
        
        #region Properties
        public WinButton UIOKButton
        {
            get
            {
                if ((this.mUIOKButton == null))
                {
                    this.mUIOKButton = new WinButton(this);
                    #region Search Criteria
                    this.mUIOKButton.SearchProperties[WinButton.PropertyNames.Name] = "OK";
                    this.mUIOKButton.WindowTitles.Add("OK");
                    #endregion
                }
                return this.mUIOKButton;
            }
        }
        #endregion
        
        #region Fields
        private WinButton mUIOKButton;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "14.0.23107.0")]
    public class UIChatRoomWindow : WpfWindow
    {
        
        public UIChatRoomWindow()
        {
            #region Search Criteria
            this.SearchProperties[WpfWindow.PropertyNames.Name] = "ChatRoom";
            this.SearchProperties.Add(new PropertyExpression(WpfWindow.PropertyNames.ClassName, "HwndWrapper", PropertyExpressionOperator.Contains));
            this.WindowTitles.Add("ChatRoom");
            #endregion
        }
        
        #region Properties
        public WpfEdit UIMessageBoxEdit
        {
            get
            {
                if ((this.mUIMessageBoxEdit == null))
                {
                    this.mUIMessageBoxEdit = new WpfEdit(this);
                    #region Search Criteria
                    this.mUIMessageBoxEdit.SearchProperties[WpfEdit.PropertyNames.AutomationId] = "messageBox";
                    this.mUIMessageBoxEdit.WindowTitles.Add("ChatRoom");
                    #endregion
                }
                return this.mUIMessageBoxEdit;
            }
        }
        
        public WpfButton UISendButton
        {
            get
            {
                if ((this.mUISendButton == null))
                {
                    this.mUISendButton = new WpfButton(this);
                    #region Search Criteria
                    this.mUISendButton.SearchProperties[WpfButton.PropertyNames.AutomationId] = "Send";
                    this.mUISendButton.WindowTitles.Add("ChatRoom");
                    #endregion
                }
                return this.mUISendButton;
            }
        }
        #endregion
        
        #region Fields
        private WpfEdit mUIMessageBoxEdit;
        
        private WpfButton mUISendButton;
        #endregion
    }
}