<template>
	<view>
		<view class="discountcard">
			<view class="discount-top">
				<view class="tip">活动</view>
				<view class="discount-title">{{value.floorName}}</view>
			</view>
			<view class="discount-info">
				<i class="iconfont icon-time" style="color:#9aa0a6 !important;font-size: 30upx !important;"></i>
				<view class="textcolor">剩余<text style="color: red;">{{day}}天{{hour}}时{{min}}分{{second}}秒</text></view>
				<i class="iconfont icon-user" style="color:#9aa0a6 !important;font-size: 30upx !important;margin-left: 20rpx;"></i>
				<view style="color: red;">{{value.peopleNumber}}<text class="textcolor">人已报名</text></view>
			</view>
			<view class="discount-img">
				<image :src="value.imgHeader"></image>
			</view>
			<view class="discount-title">{{value.alias}}</view>
			<view class="discount-desc">
				<view class="textcolor descitem">
					<view>{{value.address}}亭</view>建面<view>{{value.area}}㎡</view>
				</view>
				<view>
					<view style="color: #fa4600;font-size: 24upx;"><text class="discount-price">{{this.value.floorPrice}}</text>元</view>
					<view class="textcolor">售价待定</view>
				</view>
			</view>
			<view class="discount-buttom">
				<button class="discount-btn cu-btn" style="margin-right: 20px; background: #43d34d;color: #fff;">电话咨询</button>
				<button class="discount-btn cu-btn" style="background: #ff552e;color: #fff;">立即报名</button>
			</view>
		</view>
	</view>
</template>

<script>
	export default {
		props: {
			value: {
				type: Object,
				default: {},
				scutTime: '',

			}
		},
		computed: {
			_floorPrice() {
				return this.value.floorPrice.includes('万') ? this.value.floorPrice : this.value.floorPrice + '元/㎡'
			},
		},
		data() {
			return {

				day: '0',
				hour: '00',
				min: '00',
				second: '00',
			}
		},
		mounted() {
			this.scutTime = this.value.openingTime;
			this.countTime();
		},
		methods: {
			//时间到计时
			countTime() {
				// 获取当前时间
				let date = new Date()
				let now = date.getTime()
				// 设置截止时间
				let endDate = new Date(this.scutTime) // this.curStartTime需要倒计时的日期
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
		}
	}
</script>

<style lang="less">
	.icon {
		width: 40upx;
		height: 40upx;
	}

	.textcolor {
		color: #9aa0a6;
		font-size: 24upx;
	}

	.discount-price {
		color: #fa4600;
		font-size: 48upx;
		font-weight: bold;
	}

	.discountcard {
		margin-bottom: 20upx;
		display: flex;
		flex-direction: column;
		padding: 20upx 30upx;
		margin: 30upx;
		background: #fff;
		border-radius: 9upx;

		.discount-top {
			display: flex;

			.tip {
				width: 70upx;
				line-height: 20px;
				background: #21b0f3;
				border-radius: 10upx;
				text-align: center;
				color: #fff;
				margin-right: 10upx
			}

			.discount-title {
				width: 95%;
				overflow: hidden;
				text-overflow: ellipsis;
				white-space: nowrap;
				font-weight: bold;
			}
		}

		.discount-info {
			display: flex;
			font-size: 24upx;
			align-items: center;
			height: 70rpx;
		}

		.discount-img image {
			width: 100%;
			height: 300upx;
		}

		.discount-desc {
			display: flex;
			justify-content: space-between;
			align-items: center;
			min-height: 70rpx;

			.descitem {
				display: flex;
			}
		}

		.discount-buttom {
			display: flex;
			padding-top: 20upx;
			border-top: 1upx solid #eee;
			margin-top: 20upx;
			justify-content: space-between;

			.discount-btn {
				flex: 1;
			}
		}
	}
</style>
