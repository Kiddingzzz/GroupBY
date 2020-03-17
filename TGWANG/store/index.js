import Vue from 'vue';
import Vuex from 'vuex';
// import createPersistedState from 'vuex-persistedstate'

Vue.use(Vuex);

const store = new Vuex.Store({
	state: {
		hasLogin: false,
		userName:'',
		loginProvider: "",
		openid: null,
		user: {},
		isUpdateHome: true
	},
	mutations: {
		/**
		 * 在main.js例引入
		 * import store from './store/index'
		 * 把store挂载到全局
		 * Vue.prototype.$store = store;
		 */

		/**
		 * 这里设置一个统一的方法,大部分用的vuex都是简单的改变一些状态,不需要写过多的mutations
		 * 使用方法 例:
		 * this.$store.update({"cityName":"北京"})
		 * 
		 *  config需要传入对象
		 * @param {*} state 
		 * @param {*Object} config 
		 */
		update(state, config) {
			// console.log(`update-state: ${JSON.stringify(config)}`);
			Object.keys(config).map((item, key) => {
				state[item] = config[item];
			})
		},
		remove(state, props) {
			props.map((item) => {
				if(state[item])
					delete state[item];
			});
		},
		login(state, provider) {
			state.hasLogin = true;
			state.loginProvider = provider;
		},
		logout(state) {
			state.hasLogin = false
			state.openid = null
		},
		setOpenid(state, openid) {
			state.openid = openid
		}
	},
	actions: {
		// lazy loading openid
		getUserOpenId: async function({
			commit,
			state
		}) {
			return await new Promise((resolve, reject) => {
				if (state.openid) {
					resolve(state.openid)
				} else {
					uni.login({
						success: (data) => {
							commit('login')
							setTimeout(function() { //模拟异步请求服务器获取 openid
								const openid = '123456789'
								console.log('uni.request mock openid[' + openid + ']');
								commit('setOpenid', openid)
								resolve(openid)
							}, 1000)
						},
						fail: (err) => {
							console.log('uni.login 接口调用失败，将无法正常使用开放接口等服务', err)
							reject(err)
						}
					})
				}
			})
		}
	},
	plugins: [
		// createPersistedState({
		// 	storage: {
		// 		getItem: key => uni.getStorageSync(key),
		// 		setItem: (key, value) => {
		// 			// console.log(`${key}-${value}`);
		// 			uni.setStorageSync(key, value);
		// 		},
		// 		removeItem: key => uni.removeStorageSync(key)
		// 	  }
		// })
	]
})

export default store;
