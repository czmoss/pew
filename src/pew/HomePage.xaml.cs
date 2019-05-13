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

namespace Pew {
	public partial class HomePage : System.Windows.Controls.Page {
		public HomePage() {
			InitializeComponent();
		}

		private void Button_Click(object sender, System.Windows.RoutedEventArgs e) {
			var page = new ProblemPage(problemListBox.SelectedItem);
			NavigationService.Navigate(page);
		}
	}
}
