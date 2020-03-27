<template>
	<view class="card">
		<view class="uni-margin-wrap">
			<swiper @click="goImgDetail()" v-if="double == 'ImgList'" class="swiper" circular :indicator-dots="indicatorDots"
			 :autoplay="autoplay" :interval="interval" :duration="duration">
				<swiper-item>
					<view class="swiper-item uni-bg-red">A</view>
				</swiper-item>
				<swiper-item>
					<view class="swiper-item uni-bg-green">B</view>
				</swiper-item>
				<swiper-item>
					<view class="swiper-item uni-bg-blue">C</view>
				</swiper-item> 
			</swiper>
			<view v-if="double == 'Video'" class="swiper">
				<view>
					<video class="vid" id="myVideo" src="https://lpvideo-10011010.anjukestatic.com/lpvideo/1143330800377315330.mp4.f30.mp4?sign=N+X+fiCyTdVncidEwaG08qyPY4NhPTEwMDExMDEwJms9QUtJRDV4UDhscUtoSVd4eUpHbnJXd3NiY0xTRzJZRmJ2Zlp4JmU9MTU4NDUwMTM3MSZ0PTE1ODQ1MDA3NzEmcj0yMDQ5MTU3NDEyJmY9JmI9bHB2aWRlbw=="
					 controls></video>
				</view>
			</view>

			<view class="tabbar">
				<view v-if="items.vtImg != 'onlyV' && items.vtImg == 'onlyQ'" :class="['bors', double == 'AllVideo' ? 'active' : '']"
				 @click="change('AllVideo')">全景</view>
				<view v-if="items.vtImg == 'onlyV' && items.vtImg != 'onlyQ'" :class="['bors', double == 'Video' ? 'active' : '']"
				 @click="change('Video')">视频</view>
				<view :class="['bors', double == 'ImgList' ? 'active' : '']" @click="change('ImgList')">图片</view>
			</view>
		</view>
		<view class="detail-Cards">
			<view class="nameF">{{items.floorName}}</view>
			<view class="nameBie">别名:{{items.alias}}</view>
			<view class="tags">
				<view class="one-Sale">在售</view>
				<view v-for="(item,index) of tagsItem" :key="index">{{item}}</view>
			</view>
			<view class="lines"></view>
			<view class="rice-ping">
				<view class="ted">
					<view class="labels">均价</view>
					<view class="jiages">{{items.floorPrice}}元/㎡</view>
				</view>
				<view class="ted">
					<view class="labels">开盘</view>
					<view class="jiage">{{items.openingTime}}</view>
				</view>
				<view class="et">
					<view class="ted">
						<view class="labels">户室</view>
						<view class="jiage">{{items.apartment}}</view>
					</view>
					<view class="ted">
						<view class="labels">面积</view>
						<view class="jiage">{{items.area}}㎡</view>
					</view>
				</view>
				<view class="ted">
					<view class="labels">地址</view>
					<view class="jiage">{{items.address}}</view>
				</view>
			</view>
			<view class="btns" @click="goInfer()">更多信息</view>
			<view class="lines"></view>
		</view>
		<view class="teel">
			<view class="tes">
				<view class="ph1">
					177&nbsp;5494&nbsp;8968
				</view>

				<view class="ph2">
					安全通话隐藏真实号码，致电售楼处了解更多信息
				</view>
			</view>
		</view>
		<view class="maps">
			<view style="font-weight:700;margin-bottom:5px;">周边配套</view>
			<view class="page-section page-section-gap">
				<map :longitude="longitude" :latitude="latitude" :show-location="showLocation" scale="14" :markers="markers"
				 @markertap="makertap()"></map>
			</view>
		</view>
		<view class="btnCan" v-if="endTag == ''">
			<view class="shijian">剩余
				<view class="fonts">
					{{day}}天{{hour}}时{{min}}分{{second}}秒
				</view>，还差1人</view>
			<view class="btn1" @click="togglePopup('center', 'image')">参与拼团</view>
		</view>
		<view class="btnCan" v-if="endTag != ''">
			<view class="lgy">{{endTag}}</view>
		</view>
		<view class="bottom">
			<view class="left">添加收藏</view>
			<view class="right">
				发起团购
			</view>
		</view>
		<uni-popup ref="image" :type="type" :custom="true" :mask-click="false" @change="change">
			<view class="uni-tip">
				<view class="popImg" @click="cancel('image')">x</view>
				<view class="uni-tip-title">参与团购</view>
				<view class="uni-tip-content">仅剩3个名额,{{day}}天{{hour}}时{{min}}分{{second}}秒后结束</view>
				<view class="uni-tip-group-button">
					<!-- <view class="uni-tip-button" @click="cancel('tip')">取消</view> -->
					<view class="uni-tip-button" @click="addTG()">发起拼团</view>
				</view>
			</view>
		</uni-popup>
	</view>
</template>

<script>
	import amap from '../../components/amap-wx/lib/amap-wx.js'
	import uniPopup from '@/components/uni-popup/uni-popup.vue'
	export default {
		components: {
			uniPopup
		},
		data() {
			return {
				type: '',
				show: false,
				ast: ['one-Sale', '', ''],
				src: '',
				double: '',
				endTag: '',
				curStartTime: '2019-07-31 08:00:00',
				day: '0',
				hour: '00',
				min: '00',
				second: '00',
				id: '',
				tagsItem: [],
				items: {},
				background: ['color1', 'color2', 'color3'],
				indicatorDots: false,
				autoplay: true,
				interval: 2000,
				duration: 500,
				amapPlugin: null,
				key: 'a93eba2f3c61d2468a451b83bf662377',
				markers: [{}],
				poisdatas: [{}, {}, {}],
				title: 'map',
				latitude: 29.82,
				longitude: 106.41,
				covers: [{
					latitude: 30.208487,
					longitude: 120.21202,
					// #ifdef APP-PLUS
					iconPath: '../../../static/app-plus/location@3x.png',
					// #endif
					// #ifndef APP-PLUS
					iconPath: '../../../static/location.png',
					// #endif
				}, {
					latitude: 30.208487,
					longitude: 120.21202,
					// #ifdef APP-PLUS
					iconPath: '../../../static/app-plus/location@3x.png',
					// #endif
					// #ifndef APP-PLUS
					iconPath: '../../../static/location.png',
					// #endif
				}]
			}
		},
		onReady: function(res) {
			// #ifndef MP-ALIPAY || MP-TOUTIAO
			this.videoContext = uni.createVideoContext('myVideo')
			// #endif
			setTimeout(() => {
				this.showVideo = true
			}, 350)
		},
		onLoad(options) {
			this.id = options.id;
			this.houseInfer(this.id);
			//时间计时
			this.GetIslist(this.id)
			var that = this;
			var amapFile = require('../../components/amap-wx/lib/amap-wx.js');
			var amapPlugin = new amapFile.AMapWX({
				key: "a93eba2f3c61d2468a451b83bf662377"
			});
			amapPlugin.getPoiAround({
				success: function(data) {
					//成功回调
					that.markers = data.markers;
					that.poisdatas = data.poisData;
					var markers_new = [];
					that.markers.forEach(function(item, index) {
						markers_new.push({
							id: item.id, //marker 序号
							width: item.width, //marker 宽度
							height: item.height, //marker 高度
							iconPath: item.iconPath, //marker 图标路径
							latitude: item.latitude, //marker  纬度
							longitude: item.longitude, //marker 经度
							//自定义标记点上方的气泡窗口
							callout: {
								padding: 2, //callout 文本边缘留白
								fontSize: 15, //callout  文字大小
								bgColor: 'blue', //callout 背景颜色
								color: '#6B8E23', //callout 文字颜色
								borderRadius: 5, //边框圆角
								display: 'BYCLICK', //callout 'BYCLICK':点击显示; 'ALWAYS':常显
								content: that.poisdatas[index].name //地理位置名称
							}
						})
					})
					that.markers = markers_new;
					// console.log("markers:" + JSON.stringify(that.markers))
					// console.log("data", JSON.stringify(that.poisdatas));
				},
				fail: function(info) {
					//失败回调
					console.log("info", info)
				}
			})
		},
		methods: {
			async GetIslist(id) {
				const data = {
					houseid: id,
					userid: '0B1A1866-0BD3-72EB-25E5-39F3973F72EB'
				}
				var res = await this.$http.get('api/cms/houseOrder/houseIs', data)
				console.log(JSON.stringify(res.items))
				res = res.items.length;
				if (res > 0) {
					this.endTag = "您已参与拼团"
				}
			},
			async houseInfer(id) {
				var res = await this.$http.get('api/cms/house/' + id + '/houseDetail');
				console.log("详情数据:" + JSON.stringify(res));
				this.items = res;
				this.curStartTime = '2020-03-29 17:51:02';
				this.tagsItem = this.items.tags.replace(' ', '').replace(/'/g, '').replace('[', '').replace(']', '').split(',');
				if (this.items.vtImg == 'onlyV') {
					console.log(this.items.vtImg)
					this.change('Video')
				}
				if (this.items.vtImg == 'onlyQ') {
					this.change('AllVideo')
				}
				this.countTime()
			},
			async addTG() {
				this.toast3Tap()
				var data = {
					Userid: '0B1A1866-0BD3-72EB-25E5-39F3973F72EB',
					Houseid: this.id,
				}
				await this.$http.post('api/cms/houseOrder/houserOrder', data).then(res => {
					uni.hideToast()
					this.$refs['image'].close()
					this.toast2Tap()
					this.GetIslist(this.id)
				})

			},
			//发起参与拼团
			togglePopup(type, open) {
				switch (type) {
					case 'top':
						this.content = '顶部弹出 popup'
						break

					case 'bottom':
						this.content = '底部弹出 popup'
						break
					case 'center':
						this.content = '居中弹出 popup'
						break
				}
				this.type = type
				this.$refs[open].open()
			},
			cancel(type) {
				// if (type === 'tip') {
				// 	this.show = false
				// 	return
				// }
				this.$refs[type].close()
			},
			toast2Tap: function() {
				uni.showToast({
					title: "报名成功",
					duration: 3000
				})
			},
			toast3Tap: function() {
				uni.showToast({
					title: "loading",
					icon: "loading",
					duration: 2000
				})
			},
			//时间到计时
			countTime() {
				// 获取当前时间
				let date = new Date()
				let now = date.getTime()
				// 设置截止时间
				let endDate = new Date(this.curStartTime) // this.curStartTime需要倒计时的日期
				let end = endDate.getTime()
				// 时间差
				let leftTime = end - now;
				// 定义变量 d,h,m,s保存倒计时的时间
				if (leftTime >= 0) {
					// 天
					this.day = Math.floor(leftTime / 1000 / 60 / 60 / 24)
					// 时
					let h = Math.floor(leftTime / 1000 / 60 / 60 % 24)
					this.hour = h < 10 ? '0' + h : h
					// 分
					let m = Math.floor(leftTime / 1000 / 60 % 60)
					this.min = m < 10 ? '0' + m : m
					// 秒
					let s = Math.floor(leftTime / 1000 % 60)
					this.second = s < 10 ? '0' + s : s
				} else {
					this.day = 0
					this.hour = '00'
					this.min = '00'
					this.second = '00'
				}
				// 等于0的时候不调用
				if (Number(this.hour) === 0 && Number(this.day) === 0 && Number(this.min) === 0 && Number(this.second) === 0) {
					this.endTag = '拼团时间已截止';
					return
				} else {
					// 递归每秒调用countTime方法，显示动态时间效果,
					setTimeout(this.countTime, 1000)
				}
			},
			markertap() {
				for (var i = 0; i < this.markers.length; i++) {
					if (JSON.stringify(e).substring(18, 20) == this.markers[i].id) {
						// console.log("markers" + this.poisdatas[i].name + "   " + this.poisdatas[i].address);
						uni.showToast({
							title: this.poisdatas[i].name,
							mask: false,
							duration: 1500
						});
					}
				}
			},
			intervalChange(e) {
				this.interval = e.target.value
			},
			durationChange(e) {
				this.duration = e.target.value
			},
			//提示
			modalTap: function(e) {
				uni.showModal({
					content: "您已成功发起团购无需再次点击",
					showCancel: false,
					confirmText: "确定"
				})
			},
			//切换选项卡
			change(index) {
				this.double = index;
				if (this.double == 'video') {

				}
			},

			goInfer() {
				uni.navigateTo({
					url: '/pages/home/loupanParameters?id=' + this.id
				})
			},

			goImgDetail() {
				uni.navigateTo({
					url: '/pages/home/Img/ImgCenter?id=' + this.id
				})
			},
		}
	}
</script>


<style lang="less">
	map {
		width: 100%;
		height: 600upx;
	}

	.card {
		display: flex;
		flex-flow: column;

		.tabbar {
			height: 20px;
			line-height: 20px;
			top: 240px;
			left: 0;
			display: flex;
			flex-direction: row;
			justify-content: center;
			position: absolute;
			margin: auto;
			left: 0;
			right: 0;

			.bors {
				width: 50px;
				color: #FFFFFF;
				border-radius: 100px;
				text-align: center;
				font-size: 13px;
				margin-right: 5px;
				background: hsla(0, 0%, 100%, .8);


			}

			.bors.active {
				background: #3cb950;
			}

			.active {
				background: #3cb950;
			}

		}

		.detail-Cards {
			margin: -30px 10px 20px;
			font-size: 1.5rem;
			color: #333;
			padding: 20px 20px 5px;
			position: relative;
			background: #fff;
			box-shadow: 0 4px 8px 0 rgba(204, 204, 204, 0.30);

			.nameF {
				font-size: 38upx;
				font-weight: 700;
				line-height: 44upx;
			}

			.nameBie {
				color: #9aa0a6 !important;
				font-size: 30upx;
				margin-top: 8px;
				margin-bottom: 10px;
				line-height: 28upx;
			}

			.tags {
				display: flex;
				flex-direction: row;
				font-size: 24upx;

				.one-Sale {
					background-color: #76ce84;
					color: white;
					padding: 3px 5px !important;
				}

				view {
					margin-right: 10upx;
					color: #828890;
					padding: 3px 5px !important;
					background: #f3f5f7;


				}
			}

			.lines {
				margin: 30upx 0upx;
				height: 1px;
				width: 100%;
				border-top: 1px solid #e6e6e6;
			}

			.rice-ping {
				display: flex;
				flex-flow: column;
				width: 100%;

				.et {
					display: flex;
					flex-direction: row;
					justify-content: space-between;
				}

				.ted {
					display: flex;
					flex-direction: row;
				}

				.labels {
					font-size: 30upx;
					min-width: 40px;
					text-align: justify;
					text-align-last: justify;
					color: #9aa0a6;
					height: 24px;
					line-height: 24px;
					margin-right: 24upx;
				}

				.jiage {
					font-size: 30upx;
				}

				.jiages {
					font-size: 38upx;
					color: #fa4600 !important;
				}
			}

			.btns {
				width: 100%;
				height: 80upx;
				background: #f3f5f7 !important;
				text-align: center;
				font-size: 36upx;
				line-height: 38px;
				color: #8099af;
			}
		}

		.teel {
			margin: 0upx 20upx;
			margin-top: 30upx;
			height: 140upx;
			border: 1px solid;
			padding: 15px 15px 15px 20px;
			font-size: 1.2rem;
			margin-bottom: 40upx;
			color: #555;
			background-image: linear-gradient(to right, #d9e7fc, #dff5db);
			opacity: 1;

			.tes {
				display: flex;
				flex-flow: column;

				.ph1 {
					font-size: 2rem;
					color: #000;
					font-weight: 800;
					margin-bottom: 12upx;
				}

				.ph2 {
					font-size: 24upx;
				}
			}
		}

		.maps {
			margin: 0upx 20upx;
			margin-bottom: 80px;
		}

		.btnCan {
			width: 100%;
			position: fixed;
			bottom: 36px;
			left: 0;
			font-size: 24upx;
			line-height: 30px;
			height: 33px;
			z-index: 999;
			display: flex;
			flex-direction: row;
			justify-content: space-around;
			background: #fff5b2;
			align-items: center;

			.lgy {
				font-weight: 700;
				font-size: 32upx;
			}

			.shijian {
				display: flex;
				flex-direction: row;

				.fonts {
					color: red;
				}
			}

			.btn1 {
				margin-top: 2px;
				width: 68px;
				height: 28px;
				color: #fff;
				background: red;
				text-align: center;
				border-radius: 2px;
			}

		}

		.bottom {
			width: 100%;
			position: fixed;
			bottom: 0;
			left: 0;
			z-index: 999;
			display: flex;
			flex-direction: row;
			justify-content: space-between;
			height: 36px;
			line-height: 36px;
			font-size: 28upx;
			color: #fff;
			z-index: 99999;

			.right {
				height: 60px;
				text-align: center;
				width: 70%;
				background: #f3aba7;
			}

			.left {
				height: 60px;
				text-align: center;
				width: 30%;
				background: #e02e24;
			}
		}
	}

	.vid {
		width: 100%;
		height: 268px;

	}

	.uni-margin-wrap {
		width: 100%;
		height: 540upx;
	}

	.swiper {
		height: 540upx;
	}

	.swiper-item {
		background: red;
		display: block;
		height: 540upx;
		line-height: 300upx;
		text-align: center;
	}

	.swiper-list {
		margin-top: 40rpx;
		margin-bottom: 0;
	}

	.uni-common-mt {
		margin-top: 60rpx;
		position: relative;
	}

	.info {
		position: absolute;
		right: 20rpx;
	}

	.tab-body {
		padding: -10px;
	}

	.uni-padding-wrap {
		width: 550rpx;
		padding: 0 100rpx;
	}

	.uni-tip {
		padding: 15px;
		width: 300px;
		background: #fff;
		box-sizing: border-box;
		border-radius: 10px;
	}

	.uni-tip-title {
		text-align: center;
		font-weight: bold;
		font-size: 16px;
		color: #333;
	}

	.uni-tip-content {
		padding: 15px;
		font-size: 14px;
		color: #666;
	}

	.uni-tip-group-button {
		margin-top: 10px;
		display: flex;
		background: #e02e24;
		line-height: 29px;
		border-radius: 5px;

	}

	.uni-tip-button {
		width: 100%;
		text-align: center;
		font-size: 15px;
		color: #fff;
	}

	.popImg {
		position: absolute;
		right: 8px;
		top: -4px;
		font-weight: 600;

	}
</style>
