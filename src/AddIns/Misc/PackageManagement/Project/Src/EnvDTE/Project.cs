﻿// Copyright (c) AlphaSierraPapa for the SharpDevelop Team (for details please see \doc\copyright.txt)
// This code is distributed under the GNU LGPL (for details please see \doc\license.txt)

using System;
using ICSharpCode.SharpDevelop.Project;

namespace ICSharpCode.PackageManagement.EnvDTE
{
	public class Project
	{
		MSBuildBasedProject project;
		
		public Project(MSBuildBasedProject project)
		{
			this.project = project;
			Object = new ProjectObject(project);
			Properties = new Properties(project);
		}
		
		public string Name {
			get { return "Test"; }
		}
		
		public ProjectObject Object { get; private set; }
		public Properties Properties { get; private set; }
	}
}
