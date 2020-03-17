const KEY_ACCESS_TOKEN = 'ACCESS_TOKEN';

function _message(message, icon, settings){
	let options = {
		title: message
	};
	if(icon) options.icon = icon;
	if(settings) object.assign(options, settings);
	uni.showToast(options);
}
export default {
	hasLogin() {
		return !!this.getAuthCode();
	},
	getAuthCode: function () {
		return uni.getStorageSync(KEY_ACCESS_TOKEN);
	},
	setAuthCode: function ($authcode) {
		uni.setStorageSync(KEY_ACCESS_TOKEN, $authcode);
	},
	goHome: function () {
		uni.switchTab({
			url: '/pages/index/index'
		})
	},
	html: function (html) {
		html = html.replace(/<img /g, '<img style="max-width:100%;height:auto;"');
		html = html.replace(/&hellip;/g, '');
		return html;
	},
	set(key, value) {
		uni.setStorageSync(key, JSON.stringify(value));
	},
	get(key){
		return JSON.parse(uni.getStorageSync(key) || 'null') || null;
	},
	remove(key){
		return new Promise(function(resolve, reject) {
			return uni.removeStorageSync(key), resolve();
		});
	},
	clone(data) {
		return JSON.parse(JSON.stringify(data));
	},
	msg:{
		info(message,){
			_message(message);
		},
		error(message){
			_message(message, 'none'); //'/static/cuo.png'
		},
		success(message) {
			_message(message, 'success');
		},
		confirm(message){
			return new Promise(function(resolve, reject){
				uni.showModal({
					title: '温馨提示',
					content: message,
					success: function (res) {
						if (res.confirm) {
							resolve(res);
						} else if (res.cancel) {
							reject(res);
						}
					}
				});
			});
		}
	},
	getInfoFromExtra(key, extra) {
		if(extra && extra.length > 0) {
			const list =extra;
			const item = list.find(d=>d.name == key);
			if(item) return item.value;
		}
		return '';
	},
	navigateTo(page) {
		// console.log(`to:${page}`);
		uni.navigateTo({
			url: page
		});
	},
	navigateToBack(delta) {
		uni.navigateBack({
			delta: delta || 1
		});
	},
	getValueOrDefault(value, defaultVal){
		return value? value : defaultVal;
	},
	showLoading(){
		var message = arguments.length > 0 && void 0 !== arguments[0] ? arguments[0] : "加载中";
		uni.showLoading({
			title: message,
			mask: true
		});
	},
	hideLoading(){
		uni.hideLoading();
	}
}