﻿
//
// bootstrap.container
//

fw.module('bootstrap').component('container', {
    description: 'bootstrap container object',
    properties: {
        style: {
            display: 'style',
            type: null,
            dft: ''
        }
    },
    template: '<div class="container {{ properties.style }}">{{ placeholders.MAIN }}</div>',
    placeholders: { 'MAIN': {} }
});
