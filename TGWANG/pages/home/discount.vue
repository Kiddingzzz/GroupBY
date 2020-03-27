<template>
	<view>
		<view class="dis-wrap">
			<image src="../../static/bg.jpg"></image>
			<view class="masker"></view>
			<view class="dis-tit">优惠活动</view>
			<view class="dis-border"></view>
		</view>
		<view class="discountlist">
			<discount-car v-for="(item, index) of discountlist" :value="item" :key="index"></discount-car>
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
				discountlist: [

				]
			};
		},
		onLoad() {
			this.GetYhList()
		},
		methods: {

		},
		methods: {
			async GetYhList() {
				await this.$http.get('api/cms/house/ylList').then(res => {
					this.discountlist = res.items;
				})

			}
		},
	};
</script>

<style lang="less">
	.dis-wrap {
		position: relative;
		height: 380upx;
		width: 100%;

		image {
			width: 100%;
			height: 380upx;
			position: absolute;
			z-index: -2;
			top: 0;
		}

		.dis-tit {
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

	.discountlist {
		margin-top: -150upx;
		position: absolute;
		z-index: 99;
		width: 100%;

	}
</style>
