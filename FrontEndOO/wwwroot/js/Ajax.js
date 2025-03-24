let Ajax = function (_type, _url, _async, _data, _dataType, _contentType, _success, _beforeSend, _complete) {
    return $.ajax({
        type: _type,
        url: _url,
        async: _async,
        data: JSON.stringify(_data),
        dataType: _dataType,
        contentType: _contentType,
        success: _success,
        beforeSend: _beforeSend,
        complete: _complete
    });
}

let AjaxSync = function (_type, _url, _data, _dataType, _contentType, _success, _beforeSend, _complete) {
    return Ajax(_type, _url, false, _data, _dataType, _contentType, _success, _beforeSend, _complete);
}

let AjaxAsync = function (_type, _url, _data, _dataType, _contentType, _success, _beforeSend, _complete) {

    return Ajax(_type, _url, true, _data, _dataType, _contentType, _success, _beforeSend, _complete);
}