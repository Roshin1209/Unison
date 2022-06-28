
function exportTo(type) {

    $('#tblData').tableExport({
		filename: 'table_%DD%-%MM%-%YY%',
		format: type,
		cols: '2,3,4'
	});

}

function exportAll(type) {

    $('#tblData').tableExport({
		filename: 'table_%DD%-%MM%-%YY%-month(%MM%)',
		format: type
	});

}