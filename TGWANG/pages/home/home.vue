<template>
	<view class="det">
		<view class="search-wrap">
			<uni-search-bar radius="100" placeholder="请输入楼盘地址或名称" @confirm="search" />
		</view>
		<view class="tips">
			<view class="cantcgl">
				<view>
					<image class="imgs" src="../../static/房产.png"></image>
				</view>
				<view>全部楼盘</view>
			</view>
			<view class="cantcgl">
				<view>
					<image class="imgs" src="../../static/房屋交易.png"></image>
				</view>
				<view>在售楼盘</view>
			</view>
			<view class="cantcgl">
				<view>
					<image class="imgs" src="../../static/购房办理.png"></image>
				</view>
				<view>已开盘</view>
				<view class=""></view>
			</view>
			<view class="cantcgl">
				<view>
					<image class="imgs" src="../../static/房子.png"></image>
				</view>
				<view>低总价</view>
			</view>
			<view class="cantcgl">
				<view>
					<image class="imgs" src="../../static/租房.png"></image>
				</view>
				<view>小面积</view>
			</view>
		</view>

		<!-- 广告 -->
		<view class="Advertisement">
			广告位置
		</view>


		<!-- 楼盘热榜  近银行 -->
		<view class="hotTop">
			<view class="loupan">
				<image src="http://img11.soufunimg.com/viewimage/house/2018_06/29/M1C/0D/E4/ChCE4Fs2IhaIXaYEAAHU5zsk-TwABDQqQGq5DkAAdT_388/200x150c4_80_1.jpg"
				 class="loupan"></image>
				<view>楼盘热榜</view>
			</view>
			<view class="sideBank">
				<image src="http://img11.soufunimg.com/viewimage/house/2018_06/29/M1C/0D/E4/ChCE4Fs2IhaIXaYEAAHU5zsk-TwABDQqQGq5DkAAdT_388/200x150c4_80_1.jpg"
				 class="loupan"></image>
				<view>即将交房</view>
			</view>
		</view>

		<!-- 楼盘热榜  近银行 -->
		<view class="hotTop">
			<view class="hhd">
				<image src="http://img11.soufunimg.com/viewimage/house/2018_06/29/M1C/0D/E4/ChCE4Fs2IhaIXaYEAAHU5zsk-TwABDQqQGq5DkAAdT_388/200x150c4_80_1.jpg"
				 class="loupan"></image>
				<view>新盘抢先</view>
			</view>
			<view class="sideBank">
				<image src="http://img11.soufunimg.com/viewimage/house/2018_06/29/M1C/0D/E4/ChCE4Fs2IhaIXaYEAAHU5zsk-TwABDQqQGq5DkAAdT_388/200x150c4_80_1.jpg"
				 class="loupan"></image>
				<view>近银行</view>

			</view>
		</view>
		<!-- 筛选列表 -->
		<view></view>

		<!-- 组件列表 -->
		<view>
			<house-list v-for="(item,index) of list" :value="item" :key="index" v-on:click.native="goDetail(item.id)"></house-list>
		</view>
	</view>
</template>

<script>
	import uniSearchBar from '@/components/uni-search-bar/uni-search-bar.vue'
	import uniSection from '@/components/uni-section/uni-section.vue'
	import houseList from '@/pages/home/components/house-list.vue'
	export default {
		components: {
			uniSearchBar,
			uniSection,
			houseList
		},
		data() {
			return {
				list: [],
			}
		},
		onLoad() {
			this.houseDetail();
		},
		methods: {
			async houseDetail() {
				var res = await this.$http.get('api/cms/house/houseList')
				console.log('res:' + JSON.stringify(res.items));
				this.list = res.items;
			},
			//详情页面
			goDetail(id) {
				uni.navigateTo({
					url: '/pages/home/detail?id=' + id
				})
			}
		}
	}
</script>

<style lang="less">
	.det {
		display: flex;
		// height: 100vh;
		// box-sizing: border-box;
		flex-flow: column;
		padding: 30upx 40upx;

		.search-wrap {
			// background-color: #c0c6cc;
			font-size: 28upx;
			height: 120upx;
		}

		.tips {
			display: flex;
			flex-direction: row;
			justify-content: space-around;

			.cantcgl {
				height: 152upx;
				font-size: 24upx;
				color: #555;

				.imgs {
					width: 80upx;
					height: 80upx;
				}
			}
		}

		.Advertisement {
			width: 100%;
			height: 144upx;
			border: 1px solid red;
			margin-bottom: 60upx;
		}

		.hotTop {
			width: 100%;
			display: flex;
			flex-direction: row;
			justify-content: space-around;
			margin-bottom: 20upx;

			.loupan {
				height: 172upx;
				width: 100%;

				view {
					font-size: 18px;
					text-align: center;
					margin-top: -60px;
					color: #FFFFFF;
					font-weight: 700;
				}
			}

			.hhd {
				width: 100%;

				view {
					color: #FFFFFF;
					font-size: 18px;
					text-align: center;
					margin-top: -60px;
					font-weight: 700;
				}

			}

			.sideBank {
				margin-left: 10upx;
				height: 172upx;
				width: 100%;

				view {
					font-size: 18px;
					text-align: center;
					margin-top: -60px;
					color: #FFFFFF;
					font-weight: 700;
				}
			}
		}
	}
</style>
