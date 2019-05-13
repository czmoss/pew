/*
Copyright © 2019 Charles Moss

This file is part of Pew.

Pew is free software: you can redistribute it and/or modify it under the terms
of the GNU General Public License as published by the Free Software Foundation,
either version 3 of the License, or (at your option) any later version.

Pew is distributed in the hope that it will be useful, but WITHOUT ANY WARRANTY;
without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR
PURPOSE.  See the GNU General Public License for more details.

You should have received a copy of the GNU General Public License along with
Pew.  If not, see <https://www.gnu.org/licenses/>.
*/

using System.Linq;
using System.Windows.Documents;
using System.Xml;

namespace Pew {
	public partial class ProblemPage : System.Windows.Controls.Page {
		public ProblemPage() {
			InitializeComponent();
		}

		public ProblemPage(object data) : this() {
			DataContext = data;
			doc.Blocks.AddRange(UnpackParagraphs(data as XmlElement));
		}

		private static System.Collections.IEnumerable UnpackParagraphs(XmlElement element) {
			foreach (var child in element.ChildNodes.Cast<XmlNode>()) {
				yield return new Paragraph(new Run(child.InnerText));
			}
		}
	}
}
