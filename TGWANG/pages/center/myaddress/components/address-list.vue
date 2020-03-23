<template>
	<view class="address">
		<view class="addresslist">
			<view class="list">{{ value.name }}，{{ value.tel }}</view>
			<view class="list">{{ value.quyu[0] + ' ' + value.quyu[1] + ' ' + value.quyu[2] + ' ' }}{{ value.address }}</view>
			<view class="list caozuo">
				<view class="def">
					<radio-group @change="radioChange">
						<label class="radio">
							<radio class="red" style="transform:scale(0.7);color: red;" value="2" :checked="isDefault == true"/>
							默认地址
						</label>
					</radio-group>
				</view>
				<view>
					<button class="cu-btn bg-green shadow sm" @tap="showModal(value)" data-target="DialogModal1">编辑</button>
					<button class="cu-btn bg-green shadow sm" data-target="DialogModal1">删除</button>
				</view>
				<view class="cu-modal show" v-show="isShow">
					<model-address @hideModalfun='getHideModal()' :value="addressitem"></model-address>
				</view>
			</view>
		</view>
	</view>
</template>

<script>
import modelAddress from '@/pages/center/myaddress/components/model-address.vue';
export default {
	components: {
		modelAddress
	},
	props: {
		value: {
			type: Object,
			default: {}
		},
	},
	data() {
		return {
			modalName: null,
			isShow: false,
			addressitem: {},
			isDefault: false,
		};
	},

	methods: {
		showModal(item) {
			console.log(item);
			this.isShow = true;
			this.addressitem = item;
		},
		getHideModal(data) {
			this.isShow = data;
		},
		radioChange(e){
           console.log(this.value.isDefault)
		}
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
.caozuo {
	display: flex;
	flex-direction: row;
	justify-content: space-between;
	border-top: 1upx solid #f1f1f1;
	button {
		margin-left: 10upx;
	}
}

</style>
