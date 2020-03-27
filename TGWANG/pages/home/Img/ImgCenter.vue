<template>
	<view class="topbanner">
		<view class="swiper-tabbar">
			<scroll-view class="tab-body" scroll-x :scroll-left="scrollLeft">
				<!-- <news></news> -->
				<huxing v-if="currentTabKey == 'huxing'"></huxing>
				<loupan v-if="currentTabKey == 'loupan'"></loupan>
				<peitao v-if="currentTabKey == 'peitao'"></peitao>
				<shapan v-if="currentTabKey == 'shapan'"></shapan>
				<zhengzhao v-if="currentTabKey == 'zhengzhao'"></zhengzhao>
			</scroll-view>
		</view>
		<view style="display: flex;flex-direction: row;">
			<scroll-view id="tab-bar" class="scroll-tab" scroll-x="true" :scroll-left="scrollLeft">
				<view
					v-for="(tab, index) in tabBars"
					:key="tab.id"
					:class="['swiper-tab-list', tabIndex == index ? 'active-community' : '']"
					:id="tab.id"
					:data-current="index"
					@tap="tapTab(index)"
				>
					{{ tab.name }}
				</view>
			</scroll-view>
		</view>
	</view>
</template>

<script>
	import huxing from '@/pages/home/Img/components/huxing.vue'
	import loupan from '@/pages/home/Img/components/loupan.vue'
	import peitao from '@/pages/home/Img/components/peitao.vue'
	import shapan from '@/pages/home/Img/components/shapan.vue'
	import zhengzhao from '@/pages/home/Img/components/zhengzhao.vue'
	export default{
		components:{
			huxing,
			loupan,
			peitao,
			shapan,
			zhengzhao
		},
		data(){
			return{
				scrollLeft: '',
				tabIndex: 0,
				tabBars: [{
						name: '楼盘',
						id: 'loupan'
					},
					{
						name: '沙盘',
						id: 'shapan'
					},
					{
						name: '户型',
						id: 'huxing'
					},
					{
						name: '配套',
						id: 'peixun'
					},
					{
						name: '售楼',
						id: 'shoulou'
					},
					{
						name: '证照',
						id: 'zhengzhao'
					}
				],
			}
		},
		computed: {
			currentTabKey() {
				return this.tabBars[this.tabIndex].id;
			}
		},
		methods: {
				async changeTab(e) {
					let index = e.detail.current;
					if (this.isClickChange) {
						this.tabIndex = index;
						this.isClickChange = false;
						return;
					}
					let tabBar = await this.getElSize('tab-bar'),
						tabBarScrollLeft = tabBar.scrollLeft;
					let width = 0;
		
					for (let i = 0; i < index; i++) {
						let result = await this.getElSize(this.tabBars[i].id);
						width += result.width;
					}
					let winWidth = uni.getSystemInfoSync().windowWidth,
						nowElement = await this.getElSize(this.tabBars[index].id),
						nowWidth = nowElement.width;
					if (width + nowWidth - tabBarScrollLeft > winWidth) {
						this.scrollLeft = width + nowWidth - winWidth;
					}
					if (width < tabBarScrollLeft) {
						this.scrollLeft = width;
					}
					this.isClickChange = false;
					this.tabIndex = index; //一旦访问data就会出问题
				},
				getElSize(id) {
					//得到元素的size
					return new Promise((res, rej) => {
						uni.createSelectorQuery()
							.select('#' + id)
							.fields({
									size: true,
									scrollOffset: true
								},
								data => {
									res(data);
								}
							)
							.exec();
					});
				},
				async tapTab(index) {
					//点击tab-bar
					if (this.tabIndex === index) {
						return false;
					} else {
						let tabBar = await this.getElSize('tab-bar'),
							tabBarScrollLeft = tabBar.scrollLeft; //点击的时候记录并设置scrollLeft
						this.scrollLeft = tabBarScrollLeft;
						this.isClickChange = true;
						this.tabIndex = index;
					}
				}
			}
		
	}
</script>

<style lang="less">
	.topbanner{
		display: flex;
		height: 100vh;
		flex-flow: column;
		box-sizing: border-box;
		
		.swiper-tabbar{
			border: 1px solid;
			height: 90%;
			display: flex;
		}
		
		.bottom{
			border: 1px solid red;
			height: 10%;
		}
	}
	.tab-body {
		height: calc(100vh -56);
	}
	
	.status-contents {
		height: 25px;
	}
	.uni-swiper-tab{
		white-space: nowrap;
		width: 100%;
		display: flex;
		justify-content: flex-start;
	}
	.status {
		height: 0px;
		width: 100%;
		position: fixed;
		background-color: #f8f8f8;
		top: 0;
		z-index: 999;
	}	
	.scroll-tab{
		white-space: nowrap; /* 必要，导航栏才能横向*/
		border-bottom: 1rpx solid #eee;
	}
	.scroll-tab-item{
		display: inline-block; /* 必要，导航栏才能横向*/
		margin: 20rpx 30rpx 0 30rpx;
	}
	.active .scroll-tab-line{
		border-bottom: 5rpx solid red;
		border-top: 5rpx solid red;
		border-radius: 20rpx;
		width: 70rpx;
		
	}
	.swiper-tab-list {
		display: inline-block; /* 必要，导航栏才能横向*/
		margin-left: 15px;
		height: 30px;
		color: rgba(135, 135, 135, 1);
		font-size: 14px;
		text-align: left;
		font-family: 'PingFangSC-regular';
	}
	
	.swiper-box {
		display: flex;
	}
	
	.active-community {
		border-bottom: 5rpx solid #ea5404;
		color: #ea5404;
	}
		
		
	
</style>
