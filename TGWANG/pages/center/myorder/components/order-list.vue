<template>
	<view class="cu-card case">
		<view class="cu-item" style="margin-bottom: -5upx;">
			<view class="cu-list menu-avatar">
				<view class="orderlist">
					<view class="orderitem">
						<image :src="value.imgHeard"></image>
						<view class="desc">
							<view class="name">{{value.houseTitle}}</view>
							<view class="overtime">剩余时间</view>
						</view>
					</view>
					<view class="orderprice">
						<view>{{value.housePrice}}</view>
						<button class="cu-btn sm" style="width: 110upx;" v-if="value.houseType==true" >取消团购</button>
					</view>
					<!-- <view class="cu-avatar round lg" style="background-image:url(https://ossweb-img.qq.com/images/lol/web201310/skin/big10006.jpg);"></view>
					<view class="content flex-sub">
						<view class="text-grey">{{item.name}}</view>
						<view class="text-gray text-sm flex justify-between">
							十天前
							<view class="text-gray text-sm">
								<text class="cuIcon-attentionfill margin-lr-xs"></text> 10
								<text class="cuIcon-appreciatefill margin-lr-xs"></text> 20
								<text class="cuIcon-messagefill margin-lr-xs"></text> 30
							</view>
						</view>
					</view> -->
				</view>
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
		data() {
			return {
			
						
			};
		},
	
		methods:{
			
		},
		computed: {
			
		}
		
	}
</script>

<style lang="less">
	.orderlist{
		display: flex;
		flex-direction: row !important;
		justify-content: space-between;
		align-items: center;
		padding: 20upx;
		.orderitem{
			display: flex;
			flex-direction:row;
			image{
				width: 150upx !important;
				height: 100upx;
			}
			.desc{
				margin-left:15upx;
				display: flex;
				flex-direction:column;
				justify-content: space-between;
				color: #333;
				.name{
					width: 360upx;
					font-size: 28upx;
					font-weight: bold;
					display: -webkit-box;
					-webkit-box-orient: vertical;
					-webkit-line-clamp: 2;
					overflow: hidden;
				}
				.overtime{
					font-size: 20upx;
					color: #8799A3;
				}
			}
		}
		.orderprice{
			border-left: 1upx dashed #F1F1F1;
			padding-left: 16upx;
			display: flex;
			flex-direction: column;
			justify-content: space-between;
			align-items: center;
			view{
				font-size: 32upx;
				font-weight: bold;
				color: #ff552e;
				margin-bottom: 20upx;
			}
		}
	}
	.cu-btn{
		color: #fff;
		background: #e54d42 !important;
		padding: 0 6upx !important;
		display: flex;
		align-items: center;
		justify-content: center;
	}

</style>

