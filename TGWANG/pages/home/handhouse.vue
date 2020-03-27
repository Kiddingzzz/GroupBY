<template>
	<view class="bg">
		<view class="dis-wrap">
			<image class="imgtop" src="../../static/bg.jpg"></image>
			<view class="masker"></view>
			<view class="dis-tit">即将交房</view>
			<!-- <view class="dis-border"></view> -->
		</view>
		<view class="handhouselist">
			<view class="note">03月01日-03月31日，预计重庆30个楼盘即将交房，项目主要集中在巴南、大渡口、九龙坡等区域</view>
			<handhouse-car v-for="(item, index) of handhouselist" :value="item" :key="index"></handhouse-car>
		</view>
	</view>
</template>

<script>
import handhouseCar from '@/pages/home/components/handhouse-car.vue';
export default {
	components: {
		handhouseCar
	},
	data() {
		return {
			isCeng: "发发发",
			handhouselist: [
				{ 
					name: '标题标题标题标题标题标题标题标题标题标题标题标题',
					pics: require('../../static/bg.jpg'),
					price: '6700',
					address: '详细地址详细地址详细地址详细地址详细地址详细地址详细地址',
					handtime: '预计2020年3月30日5/6/7号楼交房',
					handloudong: '南区高层5#,南区高层7#,南区高层6#',
				},
				{
					name: '标题标题标题标题标题标题标题标题标题标题标题标题',
					pics: require('../../static/bg.jpg'),
					price: '6700',
					address: '详细地址详细地址详细地址详细地址详细地址详细地址详细地址',
					handtime: '预计2020年3月30日5/6/7号楼交房',
					handloudong: '南区高层5#,南区高层7#,南区高层6#',
				},
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
		height: 300upx;
		width: 100%;
		.imgtop{
			width: 100%;
			height: 300upx;
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
	.handhouselist{
		background: #fff;
		padding: 30upx;
		position: absolute;
		z-index: 99;
		width: 100%;
		.note{
			width: 100%;
			background: #fff;
			margin-top: -80upx;
			padding: 20upx 30upx;
			box-shadow: 0 8upx 20upx rgba(131,134,143,0.2);
			border-radius: 8upx;
			margin-bottom: 20upx;
			line-height: 48upx;
		}
	}
</style>
