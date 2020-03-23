<template>
	<view class="address">
		<address-list v-for="(item, index) of addressList" :value="item" :key="index"></address-list>
		<view class="padding flex flex-direction">
			<button class="cu-btn bg-red margin-tb-sm lg" @tap="showModal">添加地址</button>
		</view>
		<view class="cu-modal show" v-show="isShow">
			<model-address @hideModal="getHideModal()"></model-address>
		</view>
	</view>
</template>

<script>
import addressList from '@/pages/center/myaddress/components/address-list.vue';
import modelAddress from '@/pages/center/myaddress/components/model-address.vue';
export default {
	components: {
		addressList,
		modelAddress
	},
	data() {
		return {
			isShow: false,
			addressList: [
				{ isDefault: true, name: '小红', tel: '13500874592', quyu: ['广东省', '广州市', '海珠区'], address: '某街道某小区a栋4-2' },
				{ isDefault: false, name: '小明', tel: '13500874592', quyu: ['广东省', '广州市', '海珠区'], address: '某街道某小区a栋4-2' },
				{ isDefault: false, name: '收货人', tel: '13500874592', quyu: ['广东省', '广州市', '海珠区'], address: '某街道某小区a栋4-2' }
			]
		};
	},

	methods: {
		showModal() {
			this.isShow = true;
		},
		getHideModal(data) {
			this.isShow = data;
		},

	},
	computed: {}
};
</script>

<style lang="less">
.address {
	width: 100%;
	display: flex;
	flex-direction: column;
	.addresslist {
		display: flex;
		flex-direction: column;
		background: #fff;
		margin-bottom: 20upx;
		font-size: 24upx;
		.list {
			padding: 10upx 20upx;
		}
	}
}
</style>
