<template>
	<view class="ab">
		<swiper @change="change" class="swiper" circular :indicator-dots="indicatorDots" :interval="interval" :duration="duration"
		 ref="Myswper">
			<swiper-item :current="current" v-for="(item,index) of imgList" :value="item" :key="index">
				<view class="swiper-item uni-bg-red">A</view>
			</swiper-item>
		</swiper>
		<view class="number">
			<span class="item-num" v-if="imgList.length>1">{{current+1}}/{{imgList.length}}</span>
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
		data() {
			return {
				imgList: [{}, {}],
				current: 0,
			}
		},
		computed:{
			showLength(){
				return this.imgList.length;
			}
		},
		mounted() {
			console.log(this.imgList.length)
		},
		methods: {
			change(e) {
				this.current = e.detail.current;
				console.log(this.current)
			}
		}
	}
</script>

<style lang="less">
	.ab {
		line-height: 26px;
		font-size: 13px;
		height: 100%;
		
		.swiper{
			height: 100% !important;
		}
		.gg {
			color: #666666;

			.ggf {
				color: #000;
			}
		}
		.number{
			bottom: 25px;
			position: absolute;
			right: 5px;

		}
	}
</style>
