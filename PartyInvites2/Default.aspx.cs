﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.ModelBinding;

namespace PartyInvites2
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
            {
                GuessResponse rsvp = new GuessResponse();
                if (TryUpdateModel(rsvp, 
                    new FormValueProvider(ModelBindingExecutionContext)))
                {

                }
            }
        }
    }
}