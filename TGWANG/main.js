import Vue from 'vue'
import App from './App'
import store from './store/index';	
import http from './common/http.uni';
import common from './common/common';
Vue.prototype.$http = http;
Vue.prototype.$store = store;
Vue.prototype.$$ = common;
Vue.config.productionTip = false

App.mpType = 'app'

const app = new Vue({
		store,
    ...App
})
app.$mount()