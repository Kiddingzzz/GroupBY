<template>
	<view>
		<view class="discountcard">
			<view class="discount-top">
				<view class="tip">活动</view>
				<view class="discount-title">{{value.name}}</view>
			</view>
			<view class="discount-info">
				<i class="iconfont icon-time" style="color:#9aa0a6 !important;font-size: 30upx !important;"></i>
				<view class="textcolor">剩余<text style="color: red;">{{value.time}}</text></view>
				<i class="iconfont icon-user" style="color:#9aa0a6 !important;font-size: 30upx !important;margin-left: 20rpx;"></i>
				<view style="color: red;">{{value.people}}<text class="textcolor">人已报名</text></view>
			</view>
			<view class="discount-img">
				<image :src="value.pic"></image>
			</view>
			<view class="discount-title">{{value.xiaoquname}}</view>
			<view class="discount-desc">
				<view class="textcolor descitem"><view>{{value.quyu}}亭</view>建面<view>{{value.squre}}㎡</view></view>
				<view>
					<view v-if="status == true" style="color: #fa4600;font-size: 24upx;"><text class="discount-price">{{value.price}}</text>元/㎡</view>
					<view v-if="status == false" class="textcolor">售价待定</view>
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
				default: {}
			}
		},
		components: {
			
		},
		data() {
			return {
				status: true,
			}
		},
		onLoad() {

		},
		methods: {
			
		}
	}
</script>

<style lang="less">
	.icon{width: 40upx;height: 40upx;}
	.textcolor{ color:#9aa0a6;font-size: 24upx;}
	.discount-price{
		color: #fa4600;
		font-size: 48upx;
		font-weight: bold;
	}
	.discountcard{
		margin-bottom: 20upx;
		display: flex;
		flex-direction: column;
		padding: 20upx 30upx;
		margin: 30upx;
		background: #fff;
		border-radius: 9upx;
		.discount-top{
			display: flex;
			.tip{
				width: 70upx;
				line-height: 20px;
				background: #21b0f3;
				border-radius: 10upx;
				text-align: center;
				color: #fff;
				margin-right: 10upx
			}
			.discount-title{
				width: 95%;
				overflow: hidden;
				text-overflow: ellipsis;
				white-space: nowrap;
				font-weight: bold;
			}
		}
		.discount-info{
			display: flex;
			font-size: 24upx;
			align-items: center;
			height: 70rpx;
		}
		.discount-img image{
			width: 100%;
			height: 300upx;
		}
		.discount-desc{
			display: flex;
			justify-content: space-between;
			align-items: center;
			min-height: 70rpx;
			.descitem{
				display: flex;
			}
		}
		.discount-buttom{
			display: flex;
			padding-top: 20upx;
			border-top: 1upx solid #eee;
			margin-top: 20upx;
			justify-content: space-between;
			.discount-btn{
				flex: 1;
			}
		}
	}
	
</style>
