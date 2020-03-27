<template>
	<view class="det">
		<view class="dis-wrap">
			<view class="search-wrap">
				<uni-search-bar radius="100" placeholder="请输入楼盘地址或名称" @confirm="search" />
			</view>
			<image src="../../static/bg.jpg"></image>
			<!-- <view class="masker"></view> -->
			<view class="dis-tit"></view>
			<!-- <view class="dis-border"></view> -->
		</view>
		<view class="homebody">
		<view class="tips">
			<view class="cantcgl">
				<view class="imgs imgs1">
					<i class="iconfont icon-fangchan"></i>
			 		<!-- <image class="imgs" src="../../static/房产.png"></image> -->
				</view>
	     	    <view>全部楼盘</view>
			</view>
			<view class="cantcgl">
				<view class="imgs imgs2">
					<i class="iconfont icon-shoulou"></i>
					<!-- <image class="imgs" src="../../static/房屋交易.png"></image> -->
				</view>
				<view>在售楼盘</view>
			</view>
			<view class="cantcgl">
				<view class="imgs imgs3">
					<i class="iconfont icon-kaipan"></i>
					<!-- <image class="imgs" src="../../static/购房办理.png"></image> -->
				</view>
				<view>已开盘</view>
				<view class=""></view>
			</view>
			<view class="cantcgl">
				<view class="imgs imgs4">
					<i class="iconfont icon-fangjia"></i>
					<!-- <image class="imgs" src="../../static/房子.png"></image> -->
				</view>
				<view>低总价</view>
			</view>
			<view class="cantcgl">
				<view class="imgs imgs5">
					<i class="iconfont icon-mianji"></i>
					<!-- <image class="imgs" src="../../static/租房.png"></image> -->
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
			<view class="loupan" v-on:click.native="goNavdesc('discount')">
				<image src="http://img11.soufunimg.com/viewimage/house/2018_06/29/M1C/0D/E4/ChCE4Fs2IhaIXaYEAAHU5zsk-TwABDQqQGq5DkAAdT_388/200x150c4_80_1.jpg"
				 class="loupan"></image>
				<view>楼盘热榜</view>
			</view>
			<view class="sideBank" v-on:click.native="goNavdesc('handhouse')">
				<image src="http://img11.soufunimg.com/viewimage/house/2018_06/29/M1C/0D/E4/ChCE4Fs2IhaIXaYEAAHU5zsk-TwABDQqQGq5DkAAdT_388/200x150c4_80_1.jpg"
				 class="loupan"></image>
				<view>即将交房</view>
			</view>
		</view>
        
		<view class="tolprice">
	        <view class="pricebg">
				<view class="city">
					<view class="priceitem">
						<text class="cityname">重庆房价</text>
						<text class="pricedec" style="color: #333">城市行情</text>
					</view>
					<i class="iconfont icon-back" style="font-size:20upx; margin-top: 12upx;"></i>
				</view>
				<view class="priceitem" style="flex: 1;">
					<view><text class="price">11502</text>元/㎡</view>
					<view class="pricedec" style="display: flex;align-items: center;">二手房
					<i class="iconfont icon-up" style="font-size:20upx; color: red;"></i>
					1.49%</view>
				</view>
				<view class="priceitem" style="flex: 1;">
					<view><text class="price">11502</text>元/㎡</view>
					<view class="pricedec" style="display: flex;align-items: center;">
						新房
						<i class="iconfont icon-down" style="font-size:20upx; color: green;"></i>
						10.16%</view>
				</view>
			</view>
		</view>
		<!-- 楼盘热榜  近银行 -->
		<!-- <view class="hotTop">
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
		</view> -->
		<!-- 筛选列表 -->
		<view></view>
		<!-- 组件列表 -->
		<view>
			<house-list v-for="(item,index) of list" :value="item" :key="index" v-on:click.native="goDetail(item.id,item.address)"></house-list>
		</view>
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
				address:'',
				latitude:0,
				longitude:0,
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
			goDetail(id,address) {
				let that = this;
				uni.request({
					url:'http://restapi.amap.com/v3/geocode/geo?key=a6b206443fb3a4db7cb605744f8f6f3b&address='+address+'&city=重庆',
					method:'GET'
				}).then(res => {
						that.latitude = res[1].data.geocodes[0].location.split(',')[0]
						that.longitude = res[1].data.geocodes[0].location.split(',')[1]
						uni.navigateTo({
							url: '/pages/home/detail?id=' + id+'&latitude='+that.latitude+'&langitude='+that.longitude
						})
					})
			},
			//nav跳转详情
			goNavdesc(name){
				if(name == 'discount'){
					uni.navigateTo({
						url: '/pages/home/discount'
					})
				}else if(name == 'handhouse'){
					uni.navigateTo({
						url: '/pages/home/handhouse'
					})
				}
			},
		}
	}
</script>

<style lang="less">
	.dis-wrap{
		position: relative;
		height: 400upx;
		width: 100%;
		image{
			width: 100%;
			height: 400upx;
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
	.homebody{
		display: flex;
		flex-flow: column;
		padding: 0 20upx;
		margin-top: -100upx;
	}
	.det {
		display: flex;
		// height: 100vh;
		// box-sizing: border-box;
		flex-flow: column;

		.search-wrap {
			// background-color: #c0c6cc;
			font-size: 28upx;
			height: 120upx;
			padding: 0 60upx;
			margin-top: 50upx;
		}

		.tips {
			display: flex;
			flex-direction: row;
			justify-content: space-around;
			background: #fff;
			padding: 20upx 0;
			border-radius: 10upx;
			margin-top: 20upx;

			.cantcgl {
				height: 130upx;
				font-size: 24upx;
				color: #555;
				text-align: center;
				display: flex;
				flex-direction: column;
				align-items: center;
				justify-content: space-around;
				
				.imgs {
					width: 90rpx;
					height: 90rpx;
					text-align: center;
					line-height: 90rpx;
					border-radius: 20rpx;
				}
				.imgs1{
					background: linear-gradient(60deg, #11b942,#39e566);
				}
				.imgs2{
					background: linear-gradient(60deg, #ff6461,#ff7c73);
				}
				.imgs3{
					background: linear-gradient(45deg, #ff7f0e,#ffa04b);
				}
				.imgs4{
					background: linear-gradient(45deg, #646cf8,#9297fe);
				}
				.imgs5{
					background: linear-gradient(45deg, #3383f5,#55a7f4);
				}				
				
			}
		}

		.Advertisement {
			width: 100%;
			height: 130upx;
			border: 1px solid red;
			margin: 10px 0;
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
				display: flex;
				position: relative;

				view {
					font-size: 18px;
					text-align: center;
					position: absolute;
					z-index: 99;
					margin: 0 auto;
					width: 100%;
					line-height: 92px;
					color: #FFFFFF;
					font-weight: 700;
				}
			}

			.hhd {
				width: 100%;
				display: flex;
				position: relative;

				view {
					color: #FFFFFF;
					font-size: 18px;
					text-align: center;
					position: absolute;
					z-index: 99;
					margin: 0 auto;
					width: 100%;
					line-height: 92px;
					color: #FFFFFF;
					font-weight: 700;
					font-weight: 700;
				}

			}

			.sideBank {
				margin-left: 10upx;
				height: 172upx;
				width: 100%;
				display: flex;
				position: relative;
				view {
					font-size: 18px;
					text-align: center;
					color: #FFFFFF;
					font-weight: 700;
					position: absolute;
					z-index: 99;
					margin: 0 auto;
					width: 100%;
					line-height: 92px;
					color: #FFFFFF;
					font-weight: 700;
				}
			}
		}
		
		.tolprice{
			// background: red;
			.pricebg{
				background: url(../../static/sy_bg_fj.png) no-repeat;
				width: 100%;
				height: 100%;
				display: flex;
				padding: 20upx;
			}
		}
	}
	.priceitem{
		display: flex;
		flex-direction: column;
		align-items: center;
		.pricedec{ 
			font-size: 20upx;
			color:#9aa0a6;
		}
	}
	.price{
		font-size: 36upx;
		font-weight: bold;
	}
	.city{
		color: #333;
		flex: 1;
		display: flex;
		justify-content: center;
		border-right: 1upx solid #e7e7e7;
		.cityname{
			font-size: 34upx;
			font-weight: 550;
		}
	}
</style>
