﻿
//
// bootstrap.row-9-3
//

fw.module('bootstrap').component('row-9-3',  function () {
    return {
        description: 'bootstrap row object with two cols (9-3)',
        properties: {
            style: {
                display: 'style',
                type: null,
                dft: ''
            }
        },
        placeholders: { 'Left': {}, 'Right': {} },
        view: {}
    };
});

