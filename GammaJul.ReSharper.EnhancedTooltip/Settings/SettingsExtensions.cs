﻿using JetBrains.Annotations;
using JetBrains.Application;
using JetBrains.Application.Settings;
using JetBrains.DocumentModel;

namespace GammaJul.ReSharper.EnhancedTooltip.Settings {

	public static class SettingsExtensions {

		[NotNull]
		public static IContextBoundSettingsStore GetSettings([NotNull] this IDocument document) {
			var settingsStore = Shell.Instance.GetComponent<ISettingsStore>();
			return settingsStore.BindToContextTransient(ContextRange.Smart(document.ToDataContext()));
		}

	}

}