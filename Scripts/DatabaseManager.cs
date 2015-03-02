/*
This file is a part of Pokemon Mystery Universe.

Copyright (C) 2015 PMU Team

This program is free software: you can redistribute it and/or modify
it under the terms of the GNU Affero General Public License as published
by the Free Software Foundation, either version 3 of the License, or
(at your option) any later version.
This program is distributed in the hope that it will be useful,
but WITHOUT ANY WARRANTY; without even the implied warranty of
MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the
GNU Affero General Public License for more details.
You should have received a copy of the GNU Affero General Public License
along with this program. If not, see <http://www.gnu.org/licenses/>.
*/

namespace Script {
    using System;
    using System.Collections.Generic;
    using System.Text;

    using PMU.DatabaseConnector;
    using PMU.DatabaseConnector.SQLite;

    using Server.IO;

    public class DatabaseManager {
        //#region Fields

        //static SettingsDatabase optionsDB;

        //#endregion Fields

        //#region Properties

        //public static SettingsDatabase OptionsDB {
        //    get { return optionsDB; }
        //}

        //#endregion Properties

        #region Methods

        public static void InitOptionsDB() {
            //string dbPath = Paths.ScriptsIOFolder + "OptionsDB.sqlite";
            //optionsDB = new SettingsDatabase(new SQLite("Data Source=" + dbPath + ";Version=3;"));
        }

        #endregion Methods
    }
}