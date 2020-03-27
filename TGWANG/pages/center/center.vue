<template>
	<view class="layout">
		<view class="header" v-bind:class="{ status: isH5Plus }">
			<view class="userinfo">
				<view class="face"><image :src="userinfo.face"></image></view>
				<view class="info" v-if="isLogin==true">
					<view class="username">{{ userinfo.username }}</view>
					<view class="integral2">等级：{{ userinfo.integral }}</view>
				</view>
				<view class="info" v-if="isLogin==false">
					<view class="username">登录/注册</view>
					<view class="integral">登录后即可体验更多服务</view>
				</view>
			</view>
			<view class="setting" v-on:click.native="goLogin()"><image src="../../static/HM-PersonalCenter/next.png"></image></view>
		</view>
		<view class="orders">
			<image class="donghua" src="../../static/img/centerimg/wave.gif"></image>
			<view class="box padding-xl shadow-warp radius bg-white margin-top">
				<view class="label" v-for="(row, index) in orderTypeLise" :key="index" hover-class="hover">
					<view class="labelcon">
						<view class="icon">
							<!-- <view class="badge" v-if="row.badge > 0">{{ row.badge }}</view> -->
							<image :src="'../../static/HM-PersonalCenter/' + row.icon"></image>
						</view>
						<view class="name">{{ row.name }}</view>
					</view>
				</view>
			</view>
		</view>
		<view class="list" v-for="(list, list_i) in severList" :key="list_i">
			<view class="listitem">
				<view class="li" v-for="(li, li_i) in list" @click="goDetailPage(list_i, li_i)" v-bind:class="{ noborder: li_i == list.length - 1 }" hover-class="hover" :key="li.name">
					<view class="icon"><image :src="'../../static/HM-PersonalCenter/sever/' + li.icon"></image></view>
					<view class="text">{{ li.name }}</view>
					<image class="to" src="../../static/HM-PersonalCenter/to.png"></image>
				</view>
			</view>
		</view>
	</view>
</template>
<script>
export default {
	data() {
		return {
			isLogin: false,
			//#ifdef APP-PLUS
			isH5Plus: true,
			//#endif
			//#ifndef APP-PLUS
			isH5Plus: false,
			//#endif
			userinfo: {},
			orderTypeLise: [
				//name-标题 icon-图标 badge-角标
				{ name: '全部网站', icon: 'l1.png' },
				{ name: '已开通网站', icon: 'l2.png' },
				{ name: '未开通网站', icon: 'l3.png' }
				// { name: '待评价', icon: 'l4.png', badge: 9 },
				// { name: '退换货', icon: 'l5.png', badge: 0 }
			],
			severList: [
				[
					{ name: '我的订单', icon: 'security.png', urlname: '/pages/center/myorder/myorder'},
					{ name: '收货地址', icon: 'addr.png', urlname: '/pages/center/myaddress/myaddress' },
					{ name: '开通会员', icon: 'mingxi.png' },
					{ name: '向平台推荐网站', icon: 'quan.png' },
					{ name: '历史推荐网站', icon: 'bank.png' },
					{ name: '联系我们', icon: 'kefu.png' },
					{ name: '登录', icon: 'kefu.png', urlname: '/pages/passport/login' },
					// { name: '向平台推荐网站', icon: 'momey.png' },
				]
				// [
				// 	// { name: '抽奖', icon: 'choujiang.png' },
				// 	// { name: '向平台推荐网站', icon: 'addr.png' },
				// 	// { name: '历史推荐网站', icon: 'bank.png' },
				// 	// { name: '联系我们', icon: 'kefu.png' },
				// 	// { name: '发布结果', icon: 'point.png' },
				// 	// { name: '任务', icon: 'renw.png' }
				// ]
			]
		};
	},
	onLoad() {
		//加载
		this.init();
	},
	methods: {
		init() {
			//用户信息5
			this.userinfo = {
				face: '../../static/HM-PersonalCenter/face.jpg',
				username: '开单王08042',
				integral: '钻石会员'
			};
		},
		goLogin() {
			uni.navigateTo({
				url: '/pages/passport/login'
			})
		},
		//用户点击订单类型
		toOrderType(index) {
			// uni.showToast({ title: this.orderTypeLise[index].name });
		},
		//用户点击列表项
		goDetailPage(list_i, li_i) {
			uni.navigateTo({ url: this.severList[list_i][li_i].urlname })
			//uni.showToast({ title: this.severList[list_i][li_i].name });
		}
	}
};
</script>

<style lang="less">
@import "../../colorui/main.css";
@import "../../colorui/icon.css";
.layout {
	display: flex;
	width: 100%;
	height: 100%;
	flex-flow: column;
}
page {
	background-color: #f1f1f1;
}
.header {
	&.status {
		padding-top: var(--status-bar-height);
	}
	background: linear-gradient(to right, #1278f6, #00b4aa);
	width: 100%;
	height: 41vw;
	padding: 4% 4% 0 4%;
	display: flex;
	align-items: center;
	justify-content: center;
	.userinfo {
		width: 85%;
		display: flex;
		align-items: center;
		.face {
			flex-shrink: 0;
			width: 15vw;
			height: 15vw;
			image {
				width: 100%;
				height: 100%;
				border-radius: 100%;
			}
		}
		.info {
			display: flex;
			flex-flow: wrap;
			padding-left: 30upx;
			.username {
				width: 100%;
				color: #fff;
				font-size: 40upx;
			}
			.integral {
				display: flex;
				align-items: center;
				height: 40upx;
				color: #fff;
				border-radius: 20upx;
				font-size: 24upx;
			}
			.integral2:extend(.integral){
			  background-color: rgba(0, 0, 0, 0.1);
			}
		}
	}
	.setting {
		flex-shrink: 0;
		width: 6vw;
		height: 6vw;
		image {
			width: 6vw;
			height: 6vw;
		}
	}
}
.hover {
	background-color: #eee;
}
.orders {
	background: linear-gradient(to right, #1278f6, #00b4aa);
	height: 100upx;
	margin-bottom: 22vw;
	margin-top: -90rpx;
	// width: 92%;
	// height: 16vw;
	// padding: 0 4%;
	// margin-bottom: calc(11vw + 5upx);
	// display: flex;
	// align-items: flex-start;
	// border-radius: 0 0 100% 100%;
	// margin-top: -1upx;
	// display: flex;
	// flex-direction: column;
	.donghua{
			width: 100%;
			height: 100upx;
			mix-blend-mode: screen; 
	}
	.box {
		width: 100%;
		padding: 0 1%;
		height: 18vw;
		background-color: #fefefe;
		box-shadow: 0 0 0rpx rgba(0, 0, 0, 0.1);
		margin-top: -10rpx;
		display: flex;
		align-items: center;
		justify-content: center;
		.label {
			display: flex;
			align-items: center;
			justify-content: center;
			flex-flow: wrap;
			width: 100%;
			height: 16vw;
			color: #666666;
			font-size: 26upx;
			.labelcon {
				display: flex;
				flex-direction: column;
				align-items: center;
				justify-content: space-around;
				.icon {
					position: relative;
					width: 7vw;
					height: 7vw;
					margin: 0 1vw;
					// .badge {
					// 	position: absolute;
					// 	width: 4vw;
					// 	height: 4vw;
					// 	background-color: #ec6d2c;
					// 	top: -1vw;
					// 	right: -1vw;
					// 	border-radius: 100%;
					// 	font-size: 20upx;
					// 	color: #fff;
					// 	display: flex;
					// 	align-items: center;
					// 	justify-content: center;
					// 	z-index: 10;
					// }
					image {
						width: 7vw;
						height: 7vw;
						z-index: 9;
					}
				}
			}
		}
	}
}
.list {
	width: 100%;
	border-bottom: solid 26upx #f1f1f1;
	display: flex;
	justify-content: center;
	.listitem{
		width: 90%;
		border-radius: 10px;
		border: 1rpx solid #EEEEEE;
		background: #FFFFFF;
		.li {
			width: 100%;
			height: 100upx;
			padding: 0 4%;
			border-bottom: solid 1upx #e7e7e7;
			display: flex;
			align-items: center;
			&.noborder {
				border-bottom: 0;
			}
			.icon {
				flex-shrink: 0;
				width: 50upx;
				height: 50upx;
				image {
					width: 50upx;
					height: 50upx;
				}
			}
			.text {
				padding-left: 20upx;
				width: 100%;
				color: #666;
			}
			.to {
				flex-shrink: 0;
				width: 40upx;
				height: 40upx;
			}
		}
	
	}
}
</style>
