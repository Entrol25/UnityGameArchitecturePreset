﻿using System;
using UnityEngine;

namespace VavilichevGD.Architecture.UserInterface {
	public partial interface IUIElementOnLayer : IUIElement, IArchitectureCaptureEvents {
		UILayerType layer { get; }
	}
}