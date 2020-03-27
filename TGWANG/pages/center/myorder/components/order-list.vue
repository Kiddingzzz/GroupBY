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
						<button class="cu-btn sm" @click="NotTuan(value.id)" style="width: 110upx;" v-if="value.houseType==true">取消团购</button>
					</view>
					<uni-popup ref="showtip" :type="type" :mask-click="false">
						<view class="uni-tip">
							<text class="uni-tip-title">提示</text>
							<text class="uni-tip-content">确定取消团购吗？</text>
							<view class="uni-tip-group-button">
								<text class="uni-tip-button" @click="cancel()">取消</text>
								<text class="uni-tip-button" @click="NotTuanOk(value.id)">确定</text>
							</view>
						</view>
					</uni-popup>
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
				type: 'center',

			};
		},

		methods: {
			NotTuan() {
				this.$nextTick(() => {
					this.$refs['showtip'].open()
				})
			},
			cancel() {
				this.$refs['showtip'].close()
			},
			async NotTuanOk(id) {
				await this.$http.post('/api/cms/houseOrder/deleTuan/' + id + '').then(res => {
					this.$emit('hideModalor')
					this.$refs['showtip'].close()

				})

			}
		},
		computed: {

		}

	}
</script>

<style lang="less">
	/* 提示窗口 */
	.uni-tip {
		/* #ifndef APP-NVUE */
		display: flex;
		flex-direction: column;
		/* #endif */
		padding: 15px;
		width: 300px;
		background-color: #fff;
		border-radius: 10px;
	}

	.uni-tip-title {
		margin-bottom: 10px;
		text-align: center;
		font-weight: bold;
		font-size: 16px;
		color: #333;
	}

	.uni-tip-content {
		/* padding: 15px;
	*/
		font-size: 14px;
		color: #666;
	}

	.uni-tip-group-button {
		/* #ifndef APP-NVUE */
		display: flex;
		/* #endif */
		flex-direction: row;
		margin-top: 20px;
	}

	.uni-tip-button {
		flex: 1;
		text-align: center;
		font-size: 14px;
		color: #3b4144;
	}

	.orderlist {
		display: flex;
		flex-direction: row !important;
		justify-content: space-between;
		align-items: center;
		padding: 20upx;

		.orderitem {
			display: flex;
			flex-direction: row;

			image {
				width: 150upx !important;
				height: 100upx;
			}

			.desc {
				margin-left: 15upx;
				display: flex;
				flex-direction: column;
				justify-content: space-between;
				color: #333;

				.name {
					width: 360upx;
					font-size: 28upx;
					font-weight: bold;
					display: -webkit-box;
					-webkit-box-orient: vertical;
					-webkit-line-clamp: 2;
					overflow: hidden;
				}

				.overtime {
					font-size: 20upx;
					color: #8799A3;
				}
			}
		}

		.orderprice {
			border-left: 1upx dashed #F1F1F1;
			padding-left: 16upx;
			display: flex;
			flex-direction: column;
			justify-content: space-between;
			align-items: center;

			view {
				font-size: 32upx;
				font-weight: bold;
				color: #ff552e;
				margin-bottom: 20upx;
			}
		}
	}

	.cu-btn {
		color: #fff;
		background: #e54d42 !important;
		padding: 0 6upx !important;
		display: flex;
		align-items: center;
		justify-content: center;
	}
</style>
