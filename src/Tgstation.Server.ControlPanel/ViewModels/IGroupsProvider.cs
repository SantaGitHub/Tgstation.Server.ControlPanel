﻿using System.Collections.Generic;
using Tgstation.Server.Api.Models;

namespace Tgstation.Server.ControlPanel.ViewModels
{
	interface IGroupsProvider
	{
		IReadOnlyList<UserGroup> GetGroups();
	}
}