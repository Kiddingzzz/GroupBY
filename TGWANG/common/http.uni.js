import config from './config';
import app from './common';

const api_host = config.API_HOST;

function _request(api, method, data, header = {}) {
	// uni.showLoading({
	// 	title: '加载中' //数据请求前loading
	// });

	console.time('Ajax?' + api);
	let _logTimeEnd = function () {
		console.timeEnd('Ajax?' + api)
	};

	// 设置Token
	const token = app.getAuthCode();
	// console.log(`token:${token}`);
	if (token) {
		header = Object.assign(header, {
			Authorization: `Bearer ${token}`
		})
	}

	const targetApi = api.indexOf('http') != -1 ? api : `${api_host}/${api}`
	return new Promise((resolve, reject) => {
		uni.request({
			url: targetApi,
			data: data,
			method: method,
			header: {
				'content-type': 'application/json', // 默认值
				...header
			},
			success: function (res) {
				// console.log(`request:${JSON.stringify(res)}`);
				if(res.data.__abp){
					// console.log(`abp-request`);
					if(res.data.success){
						resolve(res.data.result || res.data)
					}else{
						reject(res.data.error);
					}
				}else{
					resolve(res.data)
				}
			},
			fail: function (error) {
				console.error(`HTTP-ERROR:${JSON.stringify(error)}`);
				reject(error)
			},
			complete: function () {
				_logTimeEnd();
				// uni.hideLoading();
			}
		});
	})
}

let _get = function (api, data) {
	return _request(api, 'GET', data);
};
let _post = function (api, data) {
	return _request(api, 'POST', data);
};
let _del = function (api, data) {
	return _request(api, 'DELETE', data);
};
let _put = function (api, data) {
	return _request(api, 'PUT', data);
};

let _upload = function (uploadFile, fileType = 'picture', taskCallback = null) {

	return new Promise((resolve, reject) => {
		const uploadTask = uni.uploadFile({
			url: `http://192.168.0.10:7008/api/media/upload?scene=avator`, //仅为示例，非真实的接口地址
			filePath: uploadFile,
			name: 'file',
			// files: tempFilePaths,
			success: uploadFileRes => {
				const res = JSON.parse(uploadFileRes.data);
				console.log(res);
				resolve(res.url)
			},
			fail: errors => {
				reject(errors);
			}
		});
		taskCallback && taskCallback(uploadTask);

		// uploadTask &&
		// 	uploadTask.onProgressUpdate(res => {
		// 		console.log('上传进度' + res.progress);
		// 		console.log('已经上传的数据长度' + res.totalBytesSent);
		// 		console.log(
		// 			'预期需要上传的数据总长度' + res.totalBytesExpectedToSend
		// 		);
		// 	});
	});
}

export default {
	delete: _del,
	put: _put,
	post: _post,
	get: _get,
	request: _request,
	upload: _upload
}