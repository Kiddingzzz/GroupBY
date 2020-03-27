<template>
		<view class="handhouse-list">
			<view class="handhouse-desc">
				<view class="handimgs"><image :src="value.pics"></image></view>
				<view class="handhouse-text">
					<view class="txt title">{{value.name}}</view>
					<view class="txt textcolor">{{value.address}}</view>
					<view class="tag">
						<view class="tagyellow">在售</view>
						<view class="tagblue">普通住房</view>
						<view class="taggreen">花园洋房</view>
					</view>
					<view class="orange"><text class="price">{{value.price}}</text>元/平方米起</view>
				</view>
			</view>
			<view style="margin-top: 10upx;">
				<view class="txt txtdesc"><text>交房时间：</text>{{value.handtime}}</view>
				<view v-if="ishandloudong != ''" class="txt txtdesc"><text>交房楼栋：</text>{{value.handloudong}}</view>
			</view>
		</view>
</template>

<script>
export default {
	components: {
		
	},
	props: {
		value: {
			type: Object,
			default: {}
		}
	},
	data() {
		return {
			ishandloudong: this.value.handloudong,
		};
	},
	onLoad() {},
	methods: {}
};
</script>

<style lang="less">
	.orange{
		color: #ff5350;
		font-weight: bold;
	}
	.txt{
		overflow: hidden;
		text-overflow: ellipsis;
		white-space: nowrap;
		line-height: 48upx;
		color: #333;
	}
	.textcolor{ color:#9aa0a6;font-size: 24upx;}
	.txtdesc{
		width: 100%;
		line-height: 48upx;
	}
	.tagblue{
		color: #5aa0fc;
		background: #edf8ff;
		font-size: 24upx;
		padding: 4upx 6upx;
		margin-right: 12upx;
	}
	.tagyellow{
		color: #f93;
		background: #fff5e5;
		font-size: 24upx;
		padding: 4upx 6upx;
		margin-right: 12upx;
	}
	.taggreen{
		color: #42b9cb;
		background: #ecfcff;
		font-size: 24upx;
		padding: 4upx 6upx;
		margin-right: 12upx;
	}
	.handhouse-list{
		display: flex;
		flex-direction: column;
		padding: 35upx 0 30upx 0;
		background: #fff;
		border-bottom: 1upx solid #f1f1;
		.handhouse-desc{
			display: flex;
			.handimgs{
				width: 230upx;
				height: 150upx;
				margin-right: 20upx;
				image{
					width: 100%;
					height: 100%;
				}
			}
			.handhouse-text{
				width: 65%;
				display: flex;
				flex-direction: column;
				.title{
					font-size: 32upx;
					font-weight: bold;
				}
				.tag{
					display: flex;
					// flex-wrap: wrap;
				}
			}
		}
	}
</style>
