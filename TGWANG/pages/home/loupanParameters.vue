<template>
	<view class="layout">
		<!-- 参数名称 -->
		<view class="one">
			<view class="name">中建滨江星城</view>
			<view class="jihe">
				<view class="tags">
					<view>住宅</view>
					<view>今年交房</view>
					<view>项目在建</view>
					<view>南北通透</view>
					<view>大型社区</view>
				</view>
				<view>销售情况：<view>在售</view></view>
				<view>最新开盘：<view>2019-10-18</view></view>
				<view>交房时间：<view>预计1期2020年12月底交房</view></view>
				<view>环线配置：<view>暂无数据</view></view>
			</view>
		</view>
		<view class="one">
			<view class="name">销售信息</view>
			<view class="jihe">
				<view>参考单价：<view>在售</view></view>
				<view>优惠折扣：<view>暂无数据</view></view>
				<view>最低首付：<view>暂无数据</view></view>
				<view>在售户型：<view>暂无数据</view></view>
				<view>售楼地址：<view>暂无数据</view></view>
			</view>
		</view>
		<view class="one">
			<view class="name">建筑规划</view>
			<view class="jihe">
				<view>建筑类型:<view>住宅类型</view></view>
				<view>产权年限：<view>暂无数据</view></view>
				<view>装修标准：<view>暂无数据</view></view>
				<view>开发商：<view>暂无数据</view></view>
				<view>投资商：<view>暂无数据</view></view>
				<view>容积率：<view>暂无数据</view></view>
				<view>绿化率：<view>暂无数据</view></view>
				<view>规划用户：<view>暂无数据</view></view>
				<view>楼层状况：<view>暂无数据</view></view>
				<view>占地面积：<view>暂无数据</view></view>
				<view>建筑面积：<view>暂无数据</view></view>
				<view>工程进度：<view>暂无数据</view></view>
			</view>
		</view>
		<view class="one">
			<view class="name">物业信息</view>
			<view class="jihe">
				<view>物业费：<view>住宅类型</view></view>
				<view>物业公司：<view>暂无数据</view></view>
				<view>车位数：<view>暂无数据</view></view>
				<view>车位比：<view>暂无数据</view></view>
				<view>地上车位数：<view>暂无数据</view></view>
				<view>地下车位数：<view>暂无数据</view></view>
				<view>绿化率：<view>暂无数据</view></view>
			</view>
		</view>
		
		<view class="one">
			<view class="name">预售许可证</view>
			<view class="jihes">
				<sale-card v-for="(item,index) of list" :key="index" :value="item"></sale-card>
			</view>
		</view>
	</view>
</template>

<script>
	import saleCard from '@/pages/home/components/sale-card.vue';
	export default{
		components:{
			saleCard,
			id:''
		},
		data(){
			return{
				list:[{},{}],
			}
		},
		onLoad(options) {
			this.id = options.id;
		},
	}
</script>

<style lang="less">
	.layout{
		display: flex;
		height: 100%;
		width: 100%;
		flex-flow: column;
		
		.one{
			display: flex;
			flex-flow: column;
			background: #FFFFFF;
			width: 100%;
			
			.name{
				font-size: 20px;
				color: #000;
				padding: 10px 10px 8px;
			}
			.jihes{
				padding: 0 10px 10px;
				border-bottom: 10px solid #f1f1f1;
				display: flex;
				flex-flow: column;
			}
			.jihe{
				padding: 0 10px 10px;
				border-bottom: 10px solid #f1f1f1;
				
				view{
					line-height: 26px;
					font-size: 13px;
					color: #666666;
					display: flex;
					flex-direction: row;
					
					view{
						color: #000;
					}
				}
				.tags {
					display: flex;
					flex-direction: row;
					font-size: 24upx;
				
					view {
						margin-right: 10upx;
						border: 1px solid #ccc;
						color: #828890;
						padding: 3px 5px !important;
					}
				}
			}
		}
	}
</style>
