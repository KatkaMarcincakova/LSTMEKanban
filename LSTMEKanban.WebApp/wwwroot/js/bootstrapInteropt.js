window.bootstrapInteropt = {
    showModal: id => {
        $(`#${id}`).modal('show');
    },
    hideModal: id => {
        $(`#${id}`).modal('hide');
    }
};