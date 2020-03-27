<template>
	<view>
		<view class="dis-wrap">
			<image src="../../static/bg.jpg"></image>
			<view class="masker"></view>
			<view class="dis-tit">即将交房</view>
			<!-- <view class="dis-border"></view> -->
		</view>
		<!-- <view class="discountlist"><discount-car v-for="(item, index) of discountlist" :value="item" :key="index"></discount-car></view> -->
		<view class="handhouse-list">
			<view class="handhouse-desc">
				<image src="../../static/bg.jpg"></image>
				<view class="handhouse-text">
					<view class="txt">标题哦标题标题标题标题标题标题标题标题</view>
					<view class="txt textcolor">详细地址详细地址详细地址详细地址详细地址详细地址</view>
					<view class="tag"></view>
					<view class="orange"><text class="price">6000.00</text>元/平方米起</view>
				</view>
			</view>
			<view>
				<view class="txt"><text>交房时间：</text>预计2020年3月30日5/6/7号楼交房</view>
				<view v-if="isCeng != ''" class="txt"><text>交房楼栋：</text>南区高层5#,南区高层7#,南区高层6#</view>
			</view>
		</view>
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
			isCeng: "发发发",
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
	.orange{
		color: #ff5350;
	}
	.txt{
		overflow: hidden;
		text-overflow: ellipsis;
		white-space: nowrap;
	}
	.textcolor{ color:#9aa0a6;font-size: 24upx;}
	.handhouse-list{
		display: flex;
		flex-direction: column;
		.handhouse-desc{
			display: flex;
			image{
				width: 200upx;
				height: 200upx;
			}
			.handhouse-text{
				display: flex;
				flex-direction: column;
			}
		}
	}
	.dis-wrap{
		position: relative;
		height: 380upx;
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
