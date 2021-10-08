//<JMoreno 28-07-2021>
//<Modificado Por JMoreno 02-08-2021>
function CloseAndRebindInsert(arg) {
    if (arg == '0') {
        alert("Registro actualizado correctamente");
        GetRadWindow().Close();
        //GetRadWindow().BrowserWindow.refreshGridrgIndividual();
    }
    else {
        alert("Registro adicionado correctamente");
        GetRadWindow().Close();
        //GetRadWindow().BrowserWindow.refreshGridrgIndividual(1);
    }
}

