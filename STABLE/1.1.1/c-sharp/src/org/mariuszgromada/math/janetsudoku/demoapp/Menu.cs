/*
 * @(#)Menu.cs        1.0.0    2016-04-15
 *
 * You may use this software under the condition of "Simplified BSD License"
 *
 * Copyright 2016 MARIUSZ GROMADA. All rights reserved.
 *
 * Redistribution and use in source and binary forms, with or without modification, are
 * permitted provided that the following conditions are met:
 *
 *    1. Redistributions of source code must retain the above copyright notice, this list of
 *       conditions and the following disclaimer.
 *
 *    2. Redistributions in binary form must reproduce the above copyright notice, this list
 *       of conditions and the following disclaimer in the documentation and/or other materials
 *       provided with the distribution.
 *
 * THIS SOFTWARE IS PROVIDED BY MARIUSZ GROMADA ``AS IS'' AND ANY EXPRESS OR IMPLIED
 * WARRANTIES, INCLUDING, BUT NOT LIMITED TO, THE IMPLIED WARRANTIES OF MERCHANTABILITY AND
 * FITNESS FOR A PARTICULAR PURPOSE ARE DISCLAIMED. IN NO EVENT SHALL <COPYRIGHT HOLDER> OR
 * CONTRIBUTORS BE LIABLE FOR ANY DIRECT, INDIRECT, INCIDENTAL, SPECIAL, EXEMPLARY, OR
 * CONSEQUENTIAL DAMAGES (INCLUDING, BUT NOT LIMITED TO, PROCUREMENT OF SUBSTITUTE GOODS OR
 * SERVICES; LOSS OF USE, DATA, OR PROFITS; OR BUSINESS INTERRUPTION) HOWEVER CAUSED AND ON
 * ANY THEORY OF LIABILITY, WHETHER IN CONTRACT, STRICT LIABILITY, OR TORT (INCLUDING
 * NEGLIGENCE OR OTHERWISE) ARISING IN ANY WAY OUT OF THE USE OF THIS SOFTWARE, EVEN IF
 * ADVISED OF THE POSSIBILITY OF SUCH DAMAGE.
 *
 * The views and conclusions contained in the software and documentation are those of the
 * authors and should not be interpreted as representing official policies, either expressed
 * or implied, of MARIUSZ GROMADA.
 *
 * If you have any questions/bugs feel free to contact:
 *
 *     Mariusz Gromada
 *     mariuszgromada.org@gmail.com
 *     http://janetsudoku.mariuszgromada.org
 *     http://mathparser.org
 *     http://mathspace.pl
 *     http://github.com/mariuszgromada/Janet-Sudoku
 *     http://janetsudoku.codeplex.com
 *     http://sourceforge.net/projects/janetsudoku
 *     http://bitbucket.org/mariuszgromada/janet-sudoku
 *     http://github.com/mariuszgromada/MathParser.org-mXparser
 *
 *
 *                              Asked if he believes in one God, a mathematician answered:
 *                              "Yes, up to isomorphism."
 */
using System;

namespace org.mariuszgromada.math.janetsudoku.demoapp {
	/**
	 * Package level class for command line menu.
	 *
	 * @author         <b>Mariusz Gromada</b><br>
	 *                 <a href="mailto:mariuszgromada.org@gmail.com">mariuszgromada.org@gmail.com</a><br>
	 *                 <a href="http://janetsudoku.mariuszgromada.org" target="_blank">Janet Sudoku - project web page</a><br>
	 *                 <a href="http://mathspace.pl" target="_blank">MathSpace.pl</a><br>
	 *                 <a href="http://mathparser.org" target="_blank">MathParser.org - mXparser project page</a><br>
	 *                 <a href="http://github.com/mariuszgromada/Janet-Sudoku" target="_blank">Janet Sudoku on GitHub</a><br>
	 *                 <a href="http://janetsudoku.codeplex.com" target="_blank">Janet Sudoku on CodePlex</a><br>
	 *                 <a href="http://sourceforge.net/projects/janetsudoku" target="_blank">Janet Sudoku on SourceForge</a><br>
	 *                 <a href="http://bitbucket.org/mariuszgromada/janet-sudoku" target="_blank">Janet Sudoku on BitBucket</a><br>
	 *                 <a href="http://github.com/mariuszgromada/MathParser.org-mXparser" target="_blank">mXparser-MathParser.org on GitHub</a><br>
	 *
	 * @version        1.0.0
	 */
	internal class Menu {
		/**
		 * Menu title.
		 */
		internal String title;
		/**
		 * Items number in the menu.
		 */
		internal int itemsNum;
		/**
		 * Menu content
		 */
		internal String[] content;
		/**
		 * Instance of the root JanetSudoku class (demo app)
		 */
		internal JanetSudoku janetSudoku;
		/**
		 * Default constructor.
		 * @param title           Menu title {@link MenuData}.
		 * @param content         Menu content {@link MenuData}.
		 * @param janetSudoku     Root JanetSudoku class with demo app {@link JanetSudoku}.
		 * @see MenuData
		 * @see JanetSudoku
		 */
		internal Menu(String title, String[] content, JanetSudoku janetSudoku) {
			this.title = title;
			this.itemsNum = content.Length - 1;
			this.content = content;
			this.janetSudoku = janetSudoku;
		}
		/**
		 * Prints menu to the console.
		 */
		internal void consolePrintMenue() {
			janetSudoku.consolePrintPuzzle();
			JanetConsole.println();
			JanetConsole.println("----- " + title + " -----");
			for (int i = 3; i <= itemsNum; i++) {
				JanetConsole.println(content[i]);
			}
			JanetConsole.println("----- " + "General" + " -----");
			JanetConsole.println(content[1]);
			JanetConsole.println(content[2]);
			JanetConsole.println(content[0]);
		}
		/**
		 * Ask user for menu item selection.
		 * @return  Select item id {@link MenuData}.
		 *
		 * @see MenuData
		 */
		internal int getItem() {
			int selItem = 0;
			bool loop = true;
			do {
				consolePrintMenue();
				JanetConsole.println();
				JanetConsole.print("Your selection: ");
				selItem = JanetConsole.readInt();
				if ((selItem >= 0) && (selItem <= itemsNum)) loop = false;
				else JanetConsole.println(">>> !!! Please select correct menu item. !!! <<<");
			} while (loop == true);
			return selItem;
		}
	}
}