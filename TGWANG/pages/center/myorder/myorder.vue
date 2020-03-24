<template>
	<view>
		<order-list v-for="(item,index) of orderList" :value="item" :key="index"></order-list>
	</view>
</template>

<script>
	import orderList from '@/pages/center/myorder/components/order-list.vue'
	export default {
		components: {
			orderList
		},
		data() {
			return {
				orderList: [
					// {
				// 		name: '新楼盘开业',
				// 		rice: '70',
				// 		overtime: '23:28:22.3',
				// 		pic: 'https://ossweb-img.qq.com/images/lol/web201310/skin/big10006.jpg'
				// 	},
				// 	{
				// 		name: '新楼盘开业，公交便利环境优美公交便利环境优美',
				// 		rice: '70',
				// 		overtime: '23:28:22.3',
				// 		pic: 'https://ossweb-img.qq.com/images/lol/web201310/skin/big10006.jpg'
				// 	},
				// 	{
				// 		name: '新楼盘开业，公交便利环境优美公交便利环境优美',
				// 		rice: '70',
				// 		overtime: '23:28:22.3',
				// 		pic: 'https://ossweb-img.qq.com/images/lol/web201310/skin/big10006.jpg'
				// 	}
				],

			};
		},
		onLoad(){
			this.GetOrderList();
		},
		methods: {
			async GetOrderList() {
				var res= await this.$http.get('api/cms/houseOrder/houseOrderlist' + '?userid=' + '0B1A1866-0BD3-72EB-25E5-39F3973F72EB')
				this.orderList=res.items
				console.log(JSON.stringify(this.orderList))
			},
		},
		computed: {

		}

	}
</script>

<style lang="less">
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
					width: 380upx;
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
	}

	.cu-btn {
		color: #fff;
		background: #e54d42;
		font-size: 20upx;
		padding: 0 5upx;
		display: flex;
		align-items: center;
		justify-content: center;
	}
</style>
