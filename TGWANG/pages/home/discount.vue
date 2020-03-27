<template>
	<view>
		<view class="dis-wrap">
			<image src="../../static/bg.jpg"></image>
			<view class="masker"></view>
			<view class="dis-tit">优惠活动</view>
			<view class="dis-border"></view>
		</view>
		<view class="discountlist"><discount-car v-for="(item, index) of discountlist" :value="item" :key="index"></discount-car></view>
	</view>
</template>

<script>
import discountCar from '@/pages/home/components/discount-card.vue';
export default {
	components: {
		discountCar
	},
	data() {
		return {
			discountlist: [
				{ 
					name: '标题标题',
					time: '10天8时9分10秒',
					people: '30',
					pic: require('../../static/bg.jpg'),
					price: '5700',
					squre: '80-82',
					xiaoquname: '小区名',
					quyu: '重庆-渝北'
				},
				{
					name: '标题标题',
					time: '10天8时9分10秒',
					people: '30',
					pic: require('../../static/bg.jpg'),
					price: '5700',
					squre: '80-82',
					xiaoquname: '小区名',
					quyu: '重庆-渝北'
				}
			]
		};
	},
	onLoad() {},
	methods: {}
};
</script>

<style lang="less">
	.dis-wrap{
		position: relative;
		height: 380rpx;
		width: 100%;
		image{
			width: 100%;
			height: 300upx;
			height: 380upx;
			position: absolute;
			z-index: -2;
			top: 0;
		}
		.dis-tit{
			font-size: 42upx;
			font-weight: bold;
			color: #fff;
			text-align: center;
			line-height: 250upx;
		}
		.masker {
			position: absolute;
			top: 0;
			left: 0;
			background: rgba(0, 0, 0, 0.3);
			height: 100%;
			width: 100%;
			z-index: -1;
		}
		.dis-border {
			width: 100%;
			height: 80upx;
			background-image: linear-gradient(180deg, transparent, #f6f6f6);
			position: absolute;
			bottom: 0;
		}
	}
	.discountlist{
		margin-top: -150upx;
		position: absolute;
		z-index: 99;
		width: 100%;

	}
</style>
